using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004627 RID: 17959
	[Token(Token = "0x2004627")]
	public class RL02OuterBuffViewModel : IHotfixable
	{
		// Token: 0x1700410B RID: 16651
		// (get) Token: 0x0601B4A5 RID: 111781 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B4A6 RID: 111782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700410B")]
		public string topicId
		{
			[Token(Token = "0x601B4A5")]
			[Address(RVA = "0x14A3490", Offset = "0x14A2090", VA = "0x1814A3490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B4A6")]
			[Address(RVA = "0x14A34F0", Offset = "0x14A20F0", VA = "0x1814A34F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700410C RID: 16652
		// (get) Token: 0x0601B4A7 RID: 111783 RVA: 0x000A4D18 File Offset: 0x000A2F18
		[Token(Token = "0x1700410C")]
		public bool isAllNodeActivated
		{
			[Token(Token = "0x601B4A7")]
			[Address(RVA = "0x14A3410", Offset = "0x14A2010", VA = "0x1814A3410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601B4A8 RID: 111784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4A8")]
		[Address(RVA = "0x14A2840", Offset = "0x14A1440", VA = "0x1814A2840")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601B4A9 RID: 111785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4A9")]
		[Address(RVA = "0x14A2DF0", Offset = "0x14A19F0", VA = "0x1814A2DF0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0601B4AA RID: 111786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4AA")]
		[Address(RVA = "0x14A32E0", Offset = "0x14A1EE0", VA = "0x1814A32E0")]
		public RL02OuterBuffViewModel()
		{
		}

		// Token: 0x040233AD RID: 144301
		[Token(Token = "0x40233AD")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, RL02OuterBuffItemModel> nodeModel;

		// Token: 0x040233AE RID: 144302
		[Token(Token = "0x40233AE")]
		[FieldOffset(Offset = "0x18")]
		public List<RL02OuterBuffLineItemModel> lineModel;

		// Token: 0x040233AF RID: 144303
		[Token(Token = "0x40233AF")]
		[FieldOffset(Offset = "0x20")]
		public string selectNodeId;

		// Token: 0x040233B0 RID: 144304
		[Token(Token = "0x40233B0")]
		[FieldOffset(Offset = "0x28")]
		public bool isPlaying;

		// Token: 0x040233B1 RID: 144305
		[Token(Token = "0x40233B1")]
		[FieldOffset(Offset = "0x2C")]
		public int activatedNodeCount;

		// Token: 0x040233B2 RID: 144306
		[Token(Token = "0x40233B2")]
		[FieldOffset(Offset = "0x30")]
		public int tokenCount;

		// Token: 0x040233B3 RID: 144307
		[Token(Token = "0x40233B3")]
		[FieldOffset(Offset = "0x38")]
		public string tokenItemName;

		// Token: 0x040233B4 RID: 144308
		[Token(Token = "0x40233B4")]
		[FieldOffset(Offset = "0x40")]
		public bool showNodeName;

		// Token: 0x040233B6 RID: 144310
		[Token(Token = "0x40233B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x040233B7 RID: 144311
		[Token(Token = "0x40233B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x040233B8 RID: 144312
		[Token(Token = "0x40233B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isAllNodeActivated;

		// Token: 0x040233B9 RID: 144313
		[Token(Token = "0x40233B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040233BA RID: 144314
		[Token(Token = "0x40233BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x040233BB RID: 144315
		[Token(Token = "0x40233BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
