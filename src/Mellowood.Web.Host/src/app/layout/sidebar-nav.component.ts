import { Component, Injector, ViewEncapsulation, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { MenuItem } from '@shared/layout/menu-item';
import { CMSServiceServiceProxy, ContentDto, ListResultDtoOfContentDto } from '../../shared/service-proxies/service-proxies';

@Component({
    templateUrl: './sidebar-nav.component.html',
    selector: 'sidebar-nav',
    encapsulation: ViewEncapsulation.None
})
export class SideBarNavComponent extends AppComponentBase implements OnInit {

    contentMenuItems : ContentDto[] = [];

    menuItems: MenuItem[] = [
        new MenuItem(this.l('HomePage'), '', 'home', '/app/home'),

        new MenuItem(this.l('Tenants'), 'Pages.Tenants', 'business', '/app/tenants'),
        new MenuItem(this.l('Users'), 'Pages.Users', 'people', '/app/users'),
        new MenuItem(this.l('Roles'), 'Pages.Roles', 'local_offer', '/app/roles'),
        new MenuItem(this.l('About'), '', 'info', '/app/about'),

    ];

    

    constructor(
        injector: Injector,
        private _contentService : CMSServiceServiceProxy
    ) {
        super(injector);
    }

    showMenuItem(menuItem): boolean {
        if (menuItem.permissionName) {
            return this.permission.isGranted(menuItem.permissionName);
        }

        return true;
    }

    ngOnInit(): void {
        this.loadContentSB();
    }

    loadContentSB() : void {
        this._contentService.getAll()
            .subscribe((result : ListResultDtoOfContentDto) => {
                result.items.forEach(element => {
                    this.menuItems.push(new MenuItem(element.title, '', '', '/app/cms/' + element.id));
                });
            })
    }




}
