using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004750 RID: 18256
	[Token(Token = "0x2004750")]
	public class RecruitClassicGachaInitView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170041BA RID: 16826
		// (get) Token: 0x0601BA4F RID: 113231 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BA50 RID: 113232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041BA")]
		public Action onStartBtnClick
		{
			[Token(Token = "0x601BA4F")]
			[Address(RVA = "0x14FB7B0", Offset = "0x14FA3B0", VA = "0x1814FB7B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BA50")]
			[Address(RVA = "0x14FB890", Offset = "0x14FA490", VA = "0x1814FB890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170041BB RID: 16827
		// (get) Token: 0x0601BA51 RID: 113233 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BA52 RID: 113234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041BB")]
		public Action onDetailBtnClick
		{
			[Token(Token = "0x601BA51")]
			[Address(RVA = "0x14FB750", Offset = "0x14FA350", VA = "0x1814FB750")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BA52")]
			[Address(RVA = "0x14FB810", Offset = "0x14FA410", VA = "0x1814FB810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BA53 RID: 113235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA53")]
		[Address(RVA = "0x14FB560", Offset = "0x14FA160", VA = "0x1814FB560")]
		public void Render(GachaPoolClientData data)
		{
		}

		// Token: 0x0601BA54 RID: 113236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA54")]
		[Address(RVA = "0x14FB450", Offset = "0x14FA050", VA = "0x1814FB450")]
		public void EventOnStartBtnClick()
		{
		}

		// Token: 0x0601BA55 RID: 113237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA55")]
		[Address(RVA = "0x14FB340", Offset = "0x14F9F40", VA = "0x1814FB340")]
		public void EventOnDetailBtnClick()
		{
		}

		// Token: 0x0601BA56 RID: 113238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA56")]
		[Address(RVA = "0x14FB6F0", Offset = "0x14FA2F0", VA = "0x1814FB6F0")]
		public RecruitClassicGachaInitView()
		{
		}

		// Token: 0x04023DE9 RID: 146921
		[Token(Token = "0x4023DE9")]
		private const string CLASSIC_FES_HOME_DESC = "homeDescConst";

		// Token: 0x04023DEA RID: 146922
		[Token(Token = "0x4023DEA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x04023DEB RID: 146923
		[Token(Token = "0x4023DEB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtSummary;

		// Token: 0x04023DEE RID: 146926
		[Token(Token = "0x4023DEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onStartBtnClick;

		// Token: 0x04023DEF RID: 146927
		[Token(Token = "0x4023DEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onStartBtnClick;

		// Token: 0x04023DF0 RID: 146928
		[Token(Token = "0x4023DF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onDetailBtnClick;

		// Token: 0x04023DF1 RID: 146929
		[Token(Token = "0x4023DF1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onDetailBtnClick;

		// Token: 0x04023DF2 RID: 146930
		[Token(Token = "0x4023DF2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023DF3 RID: 146931
		[Token(Token = "0x4023DF3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnStartBtnClick;

		// Token: 0x04023DF4 RID: 146932
		[Token(Token = "0x4023DF4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnDetailBtnClick;

		// Token: 0x04023DF5 RID: 146933
		[Token(Token = "0x4023DF5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
