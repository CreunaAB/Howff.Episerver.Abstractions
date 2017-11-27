using System;
using System.Collections.Generic;

using EPiServer.Core;
using EPiServer.Web;

namespace Howff.Episerver.Abstractions {
	public class SiteDefinitionAdapter : ISiteDefinition {
		public ContentReference ContentAssetsRoot => SiteDefinition.Current.ContentAssetsRoot;

		public SiteDefinition Empty => SiteDefinition.Empty;

		public virtual SiteDefinition CreateWritableClone() {
			return Current.CreateWritableClone();
		}

		public SiteDefinition Current {
			get => SiteDefinition.Current;
			set => SiteDefinition.Current = value;
		}

		public ContentReference GlobalAssetsRoot => SiteDefinition.Current.GlobalAssetsRoot;

		public IList<HostDefinition> Hosts {
			get => SiteDefinition.Current.Hosts;
			set => SiteDefinition.Current.Hosts = value;
		}

		public Guid Id {
			get => SiteDefinition.Current.Id;
			set => SiteDefinition.Current.Id = value;
		}

		public bool IsReadOnly => SiteDefinition.Current.IsReadOnly;

		public object this[string key] {
			get => SiteDefinition.Current[key];
			set => SiteDefinition.Current[key] = value;
		}

		public string Name {
			get => SiteDefinition.Current.Name;
			set => SiteDefinition.Current.Name = value;
		}

		public ContentReference RootPage => SiteDefinition.Current.RootPage;

		public ContentReference SiteAssetsRoot {
			get => SiteDefinition.Current.SiteAssetsRoot;
			set => SiteDefinition.Current.SiteAssetsRoot = value;
		}

		public Uri SiteUrl {
			get => SiteDefinition.Current.SiteUrl;
			set => SiteDefinition.Current.SiteUrl = value;
		}

		public ContentReference StartPage {
			get => SiteDefinition.Current.StartPage;
			set => SiteDefinition.Current.StartPage = value;
		}

		public ContentReference WasteBasket => SiteDefinition.Current.WasteBasket;
	}
}