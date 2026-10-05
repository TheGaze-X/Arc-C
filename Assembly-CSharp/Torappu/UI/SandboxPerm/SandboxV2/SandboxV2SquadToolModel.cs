using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200443D RID: 17469
	[Token(Token = "0x200443D")]
	public class SandboxV2SquadToolModel
	{
		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x0601AB0B RID: 109323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F4D")]
		public string toolId
		{
			[Token(Token = "0x601AB0B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x0601AB0C RID: 109324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F4E")]
		public string name
		{
			[Token(Token = "0x601AB0C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x0601AB0D RID: 109325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F4F")]
		public UIItemViewModel itemModel
		{
			[Token(Token = "0x601AB0D")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x0601AB0E RID: 109326 RVA: 0x000A2F18 File Offset: 0x000A1118
		[Token(Token = "0x17003F50")]
		public bool canBuild
		{
			[Token(Token = "0x601AB0E")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x0601AB0F RID: 109327 RVA: 0x000A2F30 File Offset: 0x000A1130
		[Token(Token = "0x17003F51")]
		public int sortId
		{
			[Token(Token = "0x601AB0F")]
			[Address(RVA = "0x13D31E0", Offset = "0x13D1DE0", VA = "0x1813D31E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x0601AB10 RID: 109328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F52")]
		public string tagPicId
		{
			[Token(Token = "0x601AB10")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F53 RID: 16211
		// (get) Token: 0x0601AB11 RID: 109329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F53")]
		public string tagName
		{
			[Token(Token = "0x601AB11")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x0601AB12 RID: 109330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F54")]
		public string desc
		{
			[Token(Token = "0x601AB12")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x0601AB13 RID: 109331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F55")]
		public string usage
		{
			[Token(Token = "0x601AB13")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AB14 RID: 109332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB14")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private SandboxV2SquadToolModel()
		{
		}

		// Token: 0x0601AB15 RID: 109333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB15")]
		[Address(RVA = "0x13D2C50", Offset = "0x13D1850", VA = "0x1813D2C50")]
		public static SandboxV2SquadToolModel Create(string topicId, string toolId, bool limitCnt)
		{
			return null;
		}

		// Token: 0x0601AB16 RID: 109334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB16")]
		[Address(RVA = "0x13D2FD0", Offset = "0x13D1BD0", VA = "0x1813D2FD0")]
		private void _Load(string topicId, SandboxPermItemData itemData, SandboxV2ItemTrapData toolData, SandboxV2ItemTrapTagData tagData, int toolCntLimit)
		{
		}

		// Token: 0x0601AB17 RID: 109335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB17")]
		[Address(RVA = "0x13D3120", Offset = "0x13D1D20", VA = "0x1813D3120")]
		private void _UpdatePlayerData()
		{
		}

		// Token: 0x0601AB18 RID: 109336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB18")]
		[Address(RVA = "0x13D2FC0", Offset = "0x13D1BC0", VA = "0x1813D2FC0")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x0402212E RID: 139566
		[Token(Token = "0x402212E")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x0402212F RID: 139567
		[Token(Token = "0x402212F")]
		[FieldOffset(Offset = "0x18")]
		private string m_toolId;

		// Token: 0x04022130 RID: 139568
		[Token(Token = "0x4022130")]
		[FieldOffset(Offset = "0x20")]
		private string m_name;

		// Token: 0x04022131 RID: 139569
		[Token(Token = "0x4022131")]
		[FieldOffset(Offset = "0x28")]
		private UIItemViewModel m_itemModel;

		// Token: 0x04022132 RID: 139570
		[Token(Token = "0x4022132")]
		[FieldOffset(Offset = "0x30")]
		private string m_tagPicId;

		// Token: 0x04022133 RID: 139571
		[Token(Token = "0x4022133")]
		[FieldOffset(Offset = "0x38")]
		private string m_tagName;

		// Token: 0x04022134 RID: 139572
		[Token(Token = "0x4022134")]
		[FieldOffset(Offset = "0x40")]
		private string m_desc;

		// Token: 0x04022135 RID: 139573
		[Token(Token = "0x4022135")]
		[FieldOffset(Offset = "0x48")]
		private int m_toolCntLimit;

		// Token: 0x04022136 RID: 139574
		[Token(Token = "0x4022136")]
		[FieldOffset(Offset = "0x50")]
		private string m_usage;

		// Token: 0x04022137 RID: 139575
		[Token(Token = "0x4022137")]
		[FieldOffset(Offset = "0x58")]
		private bool m_canBuild;
	}
}
