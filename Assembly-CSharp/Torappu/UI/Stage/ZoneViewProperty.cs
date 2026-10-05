using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;

namespace Torappu.UI.Stage
{
	// Token: 0x020069FC RID: 27132
	[Token(Token = "0x20069FC")]
	[Serializable]
	public class ZoneViewProperty : DynamicBindProperty<ZoneViewProperty, ZoneViewModel>
	{
		// Token: 0x17005B93 RID: 23443
		// (get) Token: 0x06026CC0 RID: 158912 RVA: 0x000CC690 File Offset: 0x000CA890
		// (set) Token: 0x06026CC1 RID: 158913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B93")]
		public ZoneViewType zoneViewType
		{
			[Token(Token = "0x6026CC0")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			[CompilerGenerated]
			get
			{
				return ZoneViewType.NONE;
			}
			[Token(Token = "0x6026CC1")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005B94 RID: 23444
		// (get) Token: 0x06026CC2 RID: 158914 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026CC3 RID: 158915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B94")]
		public string actId
		{
			[Token(Token = "0x6026CC2")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026CC3")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026CC4 RID: 158916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CC4")]
		[Address(RVA = "0x21E82A0", Offset = "0x21E6EA0", VA = "0x1821E82A0")]
		public ZoneViewProperty()
		{
		}
	}
}
