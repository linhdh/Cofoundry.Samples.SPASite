﻿using Cofoundry.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofoundry.Samples.SPASite.Domain
{
    /// <summary>
    /// Each custom entity requires a definition class which provides settings
    /// describing the entity and how it should behave.
    /// 
    /// This definition uses ICustomisedTermCustomEntityDefinition to change
    /// the display name for the title property to be 'Name'.
    /// </summary>
    public class CatCustomEntityDefinition : ICustomizedTermCustomEntityDefinition<CatDataModel>
    {
        /// <summary>
        /// This constant is a convention that allows us to reference this definition code 
        /// in other parts of the application (e.g. querying)
        /// </summary>
        public const string DefinitionCode = "SPACAT";

        /// <summary>
        /// Unique 6 letter code representing the module (the convention is to use uppercase)
        /// </summary>
        public string CustomEntityDefinitionCode => DefinitionCode;

        /// <summary>
        /// Singlar name of the entity
        /// </summary>
        public string Name => "Cat";

        /// <summary>
        /// Plural name of the entity
        /// </summary>
        public string NamePlural => "Cats";

        /// <summary>
        /// A short description that shows up as a tooltip for the admin 
        /// panel.
        /// </summary>
        public string Description => "Each cat can be rated by the public.";

        /// <summary>
        /// Indicates whether the UrlSlug property should be treated
        /// as a unique property and be validated as such.
        /// </summary>
        public bool ForceUrlSlugUniqueness => false;

        /// <summary>
        /// Indicates whether the url slug should be autogenerated. If this
        /// is selected then the user will not be shown the UrlSlug property
        /// and it will be auto-generated based on the title.
        /// </summary>
        public bool AutoGenerateUrlSlug => true;

        /// <summary>
        /// Indicates whether this custom entity should always be published when 
        /// saved, provided the user has permissions to do so. Useful if this isn't
        /// the sort of entity that needs a draft state workflow
        /// </summary>
        public bool AutoPublish => false;

        /// <summary>
        /// Indicates whether the entities are partitioned by locale
        /// </summary>
        public bool HasLocale => false;

        /// <summary>
        /// Implementing ICustomisedTermCustomEntityDefinition gives us additional customization 
        /// settings, allowing us to give custom labels for properties such as Title and UrlSlug.
        /// Here we want the in-built Title property to be used as the cat name.
        /// </summary>
        public Dictionary<string, string> CustomTerms => new Dictionary<string, string>()
        {
            { CustomizableCustomEntityTermKeys.Title, "Name" }
        };
    }
}
