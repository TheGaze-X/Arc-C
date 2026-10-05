using System;
using Il2CppDummyDll;
using Torappu.DataBind;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004ABD RID: 19133
	[Token(Token = "0x2004ABD")]
	public class HotUpdateViewProp : DynamicBindProperty<HotUpdateViewProp, HotUpdateViewModel>
	{
		// Token: 0x0601CBB2 RID: 117682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CBB2")]
		[Address(RVA = "0x16258A0", Offset = "0x16244A0", VA = "0x1816258A0")]
		public void Init()
		{
		}

		// Token: 0x0601CBB3 RID: 117683 RVA: 0x000A9410 File Offset: 0x000A7610
		[Token(Token = "0x601CBB3")]
		[Address(RVA = "0x1625840", Offset = "0x1624440", VA = "0x181625840")]
		public bool CheckPreMainShow()
		{
			return default(bool);
		}

		// Token: 0x0601CBB4 RID: 117684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CBB4")]
		[Address(RVA = "0x1625A60", Offset = "0x1624660", VA = "0x181625A60")]
		public HotUpdateViewProp()
		{
		}

		// Token: 0x04025B68 RID: 154472
		[Token(Token = "0x4025B68")]
		[FieldOffset(Offset = "0x30")]
		public HotUpdateProgressProperty progressProp;

		// Token: 0x04025B69 RID: 154473
		[Token(Token = "0x4025B69")]
		[FieldOffset(Offset = "0x38")]
		public HotUpdatePreMainProperty premainProp;
	}
}
