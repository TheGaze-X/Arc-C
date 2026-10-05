using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;

namespace Torappu.UI.Stage
{
	// Token: 0x020069D5 RID: 27093
	[Token(Token = "0x20069D5")]
	[Serializable]
	public class ZoneGroupViewProperty : DynamicBindProperty<ZoneGroupViewProperty, ZoneGroupViewModel>
	{
		// Token: 0x17005B7B RID: 23419
		// (get) Token: 0x06026C26 RID: 158758 RVA: 0x000CC348 File Offset: 0x000CA548
		// (set) Token: 0x06026C27 RID: 158759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B7B")]
		public bool isSelected
		{
			[Token(Token = "0x6026C26")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6026C27")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06026C28 RID: 158760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C28")]
		[Address(RVA = "0x21DB580", Offset = "0x21DA180", VA = "0x1821DB580", Slot = "9")]
		public virtual void SetSelectedTypeZone(ZoneViewType zoneType)
		{
		}

		// Token: 0x06026C29 RID: 158761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C29")]
		[Address(RVA = "0x21D60A0", Offset = "0x21D4CA0", VA = "0x1821D60A0")]
		public ZoneGroupViewProperty()
		{
		}
	}
}
