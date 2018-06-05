namespace DoFactory.FactoryMethod.CMS
{
    using Pages;
    class Resume : Document
    {
        public override void CreatePages()
        {
            AddPage(new SkillsPage());
            AddPage(new EducationPage());
            AddPage(new ExperiencePage());
        }
    }
}
