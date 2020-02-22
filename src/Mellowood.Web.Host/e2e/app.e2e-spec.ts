import { MellowoodTemplatePage } from './app.po';

describe('Mellowood App', function() {
  let page: MellowoodTemplatePage;

  beforeEach(() => {
    page = new MellowoodTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
