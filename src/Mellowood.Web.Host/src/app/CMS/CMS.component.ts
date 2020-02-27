import { Component, Injector, AfterViewInit, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { CMSServiceServiceProxy, ContentDto } from '../../shared/service-proxies/service-proxies';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    templateUrl: './CMS.component.html',
    animations: [appModuleAnimation()]
})

export class CMSComponent extends AppComponentBase implements OnInit {

    id: number;
    content : ContentDto = new ContentDto();

    constructor(
        injector: Injector,
        private _CMSServer : CMSServiceServiceProxy,
        private route: ActivatedRoute
    ) {
        super(injector);
    }

    ngOnInit() : void {
        this.route.params.subscribe(params => {
            this.id = 0;
            this.id = +params['id']; // (+) converts string 'id' to a number
            this.loadContent();
        });
    }

    loadContent() {
        this._CMSServer. getCMSContent(this.id)
            .subscribe((result: ContentDto) => {
                this.content = result;
            });
    }

}
