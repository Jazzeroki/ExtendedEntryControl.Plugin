using ExtendedEntryControl.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using ExtendedEntryControl.Forms.Plugin.iOS;

[assembly: Dependency(typeof(ExtendedEntryControlImplementation))]
namespace ExtendedEntryControl.Forms.Plugin.iOS
{
	/// <summary>
	/// ExtendedEntryControl Implementation
	/// </summary>
	public class ExtendedEntryControlImplementation : IExtendedEntryControl
	{
		/// <summary>
		/// Used for registration with dependency service
		/// </summary>
		public static void Init() { }
	}
}
