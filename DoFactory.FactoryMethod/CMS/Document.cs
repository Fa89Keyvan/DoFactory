namespace DoFactory.FactoryMethod.CMS
{
    using Pages;
    using System.Collections.Generic;

    /// <summary>
    /// Creator Class (Abstract)
    /// </summary>
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }
        public List<Page> Pages => _pages;

        public abstract void CreatePages();
        public void AddPage(Page page) => this._pages.Add(page);
    }
}
