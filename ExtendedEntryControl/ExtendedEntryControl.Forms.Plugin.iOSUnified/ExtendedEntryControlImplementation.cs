using ExtendedEntryControl.Forms.Plugin.Abstractions;
using Xamarin.Forms;
using ExtendedEntryControl.Forms.Plugin.iOSUnified;

[assembly: Dependency(typeof(ExtendedEntryControlImplementation))]
namespace ExtendedEntryControl.Forms.Plugin.iOSUnified
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
