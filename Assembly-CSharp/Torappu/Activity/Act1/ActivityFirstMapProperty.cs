using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B5D RID: 31581
	[Token(Token = "0x2007B5D")]
	[Serializable]
	public class ActivityFirstMapProperty : BindProperty<ActivityFirstMapViewModel>, IHotfixable
	{
		// Token: 0x0602C344 RID: 181060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C344")]
		[Address(RVA = "0x281C570", Offset = "0x281B170", VA = "0x18281C570")]
		public void InitData(List<DefaultZoneData> zoneList)
		{
		}

		// Token: 0x0602C345 RID: 181061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C345")]
		[Address(RVA = "0x281C810", Offset = "0x281B410", VA = "0x18281C810")]
		public void SetZone(string zoneId)
		{
		}

		// Token: 0x0602C346 RID: 181062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C346")]
		[Address(RVA = "0x281C8B0", Offset = "0x281B4B0", VA = "0x18281C8B0")]
		public ActivityFirstMapProperty()
		{
		}

		// Token: 0x04040158 RID: 262488
		[Token(Token = "0x4040158")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04040159 RID: 262489
		[Token(Token = "0x4040159")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetZone;

		// Token: 0x0404015A RID: 262490
		[Token(Token = "0x404015A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
