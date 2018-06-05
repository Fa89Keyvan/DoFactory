namespace DoFactory.FactoryMethod.CMS
{
    using Pages;

    /// <summary>
    /// Concrete creator
    /// </summary>
    class Report : Document
    {
        public override void CreatePages()
        {
            AddPage(new IntroductionPage());
            AddPage(new ResultsPage());
            AddPage(new ConclusionPage());
            AddPage(new SummaryPage());
            AddPage(new BibliographyPage());
        }
    }
}
