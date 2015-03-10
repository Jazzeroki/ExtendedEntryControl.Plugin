using ExtendedEntryControl.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using ExtendedEntryControl.Forms.Plugin.Droid;

[assembly: Dependency(typeof(ExtendedEntryControlImplementation))]
namespace ExtendedEntryControl.Forms.Plugin.Droid
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
