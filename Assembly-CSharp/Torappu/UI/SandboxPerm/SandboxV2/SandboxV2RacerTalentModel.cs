using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004362 RID: 17250
	[Token(Token = "0x2004362")]
	public abstract class SandboxV2RacerTalentModel : IHotfixable
	{
		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x0601A795 RID: 108437 RVA: 0x000A1E68 File Offset: 0x000A0068
		[Token(Token = "0x17003ED1")]
		public bool isEmpty
		{
			[Token(Token = "0x601A795")]
			[Address(RVA = "0x13976E0", Offset = "0x13962E0", VA = "0x1813976E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x0601A796 RID: 108438
		[Token(Token = "0x17003ED2")]
		public abstract SandboxV2RacerTalentType type { [Token(Token = "0x601A796")] get; }

		// Token: 0x0601A797 RID: 108439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A797")]
		[Address(RVA = "0x1397500", Offset = "0x1396100", VA = "0x181397500")]
		public void LoadData(string topicId, SandboxV2RacerTalentInfo talentInfo, SandboxV2RacingConstData constData)
		{
		}

		// Token: 0x0601A798 RID: 108440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A798")]
		[Address(RVA = "0x1397680", Offset = "0x1396280", VA = "0x181397680")]
		protected SandboxV2RacerTalentModel()
		{
		}

		// Token: 0x04021AFB RID: 137979
		[Token(Token = "0x4021AFB")]
		[FieldOffset(Offset = "0x10")]
		public string talentDesc;

		// Token: 0x04021AFC RID: 137980
		[Token(Token = "0x4021AFC")]
		[FieldOffset(Offset = "0x18")]
		public string talentIcon;

		// Token: 0x04021AFD RID: 137981
		[Token(Token = "0x4021AFD")]
		[FieldOffset(Offset = "0x20")]
		public string talentTitle;

		// Token: 0x04021AFE RID: 137982
		[Token(Token = "0x4021AFE")]
		[FieldOffset(Offset = "0x28")]
		public string topicId;

		// Token: 0x04021AFF RID: 137983
		[Token(Token = "0x4021AFF")]
		[FieldOffset(Offset = "0x30")]
		private string m_talentId;

		// Token: 0x04021B00 RID: 137984
		[Token(Token = "0x4021B00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04021B01 RID: 137985
		[Token(Token = "0x4021B01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021B02 RID: 137986
		[Token(Token = "0x4021B02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
