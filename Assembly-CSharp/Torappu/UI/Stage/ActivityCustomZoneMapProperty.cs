using System;
using Il2CppDummyDll;
using Torappu.DataBind;

namespace Torappu.UI.Stage
{
	// Token: 0x020068A5 RID: 26789
	[Token(Token = "0x20068A5")]
	public class ActivityCustomZoneMapProperty : DynamicBindProperty<ActivityCustomZoneMapProperty, ActivityCustomZoneMapViewModel>
	{
		// Token: 0x17005A93 RID: 23187
		// (get) Token: 0x0602664F RID: 157263 RVA: 0x000CAD28 File Offset: 0x000C8F28
		// (set) Token: 0x06026650 RID: 157264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A93")]
		public bool isZoneMapFastMode
		{
			[Token(Token = "0x602664F")]
			[Address(RVA = "0x2176E20", Offset = "0x2175A20", VA = "0x182176E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6026650")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			set
			{
			}
		}

		// Token: 0x06026651 RID: 157265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026651")]
		[Address(RVA = "0x2176DC0", Offset = "0x21759C0", VA = "0x182176DC0")]
		public ActivityCustomZoneMapProperty()
		{
		}

		// Token: 0x04036117 RID: 221463
		[Token(Token = "0x4036117")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isZoneMapFastMode;
	}
}
