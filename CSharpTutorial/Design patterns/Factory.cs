using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Design_patterns
{
    internal class Factory
    {
        //Definition:  lets a class defer instantiation to subclasses. subclasses decide which class to instantiate
        //Link : https://www.dofactory.com/net/factory-method-design-pattern

    }

    //----------------------  The abstract class ----------------------
    abstract class Page
    {
    }

    //----------------------  The 'ConcreteProduct' classes ----------------------

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class SkillsPage : Page
    {
    }
   
    class EducationPage : Page
    {
    }
    
    class ExperiencePage : Page
    {
    }

    //----------------------  The 'Creator' abstract class ----------------------
   
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }
        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method
        public abstract void CreatePages();
    }

    //----------------------  The 'ConcreteCreator' abstract class ----------------------
    class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

}
