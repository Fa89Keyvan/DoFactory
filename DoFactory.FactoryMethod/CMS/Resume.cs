namespace DoFactory.FactoryMethod.CMS
{
    using Pages;
    class Resume : Document
    {
        public override void CreatePages()
        {
            this.Pages.Add(new SkillsPage());
            this.Pages.Add(new EducationPage());
            this.Pages.Add(new ExperiencePage());
        }
    }
}
