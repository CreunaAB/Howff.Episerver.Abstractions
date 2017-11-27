using System;
using System.Collections.Generic;

using EPiServer.Core;
using EPiServer.Web;

namespace Howff.Episerver.Abstractions {
	public interface ISiteDefinition {
		ContentReference ContentAssetsRoot { get; }
		SiteDefinition CreateWritableClone();
		SiteDefinition Current { get; set; }
		SiteDefinition Empty { get; }
		ContentReference GlobalAssetsRoot { get; }
		IList<HostDefinition> Hosts { get; set; }
		Guid Id { get; set; }
		bool IsReadOnly { get; }
		object this[string key] { get; set; }
		string Name { get; set; }
		ContentReference RootPage { get; }
		ContentReference SiteAssetsRoot { get; set; }
		Uri SiteUrl { get; set; }
		ContentReference StartPage { get; set; }
		ContentReference WasteBasket { get; }
	}
}