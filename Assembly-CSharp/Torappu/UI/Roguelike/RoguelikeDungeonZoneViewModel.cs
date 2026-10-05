using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200527D RID: 21117
	[Token(Token = "0x200527D")]
	public class RoguelikeDungeonZoneViewModel : IHotfixable
	{
		// Token: 0x17004905 RID: 18693
		// (get) Token: 0x0601F28B RID: 127627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004905")]
		public RoguelikeDungeonNode curNode
		{
			[Token(Token = "0x601F28B")]
			[Address(RVA = "0x18EA050", Offset = "0x18E8C50", VA = "0x1818EA050")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F28C RID: 127628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F28C")]
		[Address(RVA = "0x18E99B0", Offset = "0x18E85B0", VA = "0x1818E99B0")]
		public void LoadData(string topicId, bool accessedInitState, RoguelikeDungeonGeneSpZonePluginBase geneSpZonePlugin)
		{
		}

		// Token: 0x0601F28D RID: 127629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F28D")]
		[Address(RVA = "0x18E9E00", Offset = "0x18E8A00", VA = "0x1818E9E00")]
		private void _CheckAndSetZoneDiffDisplay()
		{
		}

		// Token: 0x0601F28E RID: 127630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F28E")]
		[Address(RVA = "0x18E9FA0", Offset = "0x18E8BA0", VA = "0x1818E9FA0")]
		public RoguelikeDungeonZoneViewModel()
		{
		}

		// Token: 0x04029CF3 RID: 171251
		[Token(Token = "0x4029CF3")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeDungeonZone curZone;

		// Token: 0x04029CF4 RID: 171252
		[Token(Token = "0x4029CF4")]
		[FieldOffset(Offset = "0x18")]
		public int curDepth;

		// Token: 0x04029CF5 RID: 171253
		[Token(Token = "0x4029CF5")]
		[FieldOffset(Offset = "0x1C")]
		public int curIndex;

		// Token: 0x04029CF6 RID: 171254
		[Token(Token = "0x4029CF6")]
		[FieldOffset(Offset = "0x20")]
		public bool isZoneChanged;

		// Token: 0x04029CF7 RID: 171255
		[Token(Token = "0x4029CF7")]
		[FieldOffset(Offset = "0x21")]
		public bool showAutoTransition;

		// Token: 0x04029CF8 RID: 171256
		[Token(Token = "0x4029CF8")]
		[FieldOffset(Offset = "0x22")]
		public bool showManualTransition;

		// Token: 0x04029CF9 RID: 171257
		[Token(Token = "0x4029CF9")]
		[FieldOffset(Offset = "0x28")]
		public string topicId;

		// Token: 0x04029CFA RID: 171258
		[Token(Token = "0x4029CFA")]
		[FieldOffset(Offset = "0x30")]
		public bool isVariation;

		// Token: 0x04029CFB RID: 171259
		[Token(Token = "0x4029CFB")]
		[FieldOffset(Offset = "0x38")]
		public List<string> variationIdList;

		// Token: 0x04029CFC RID: 171260
		[Token(Token = "0x4029CFC")]
		[FieldOffset(Offset = "0x40")]
		public bool isDiffDisplayZone;

		// Token: 0x04029CFD RID: 171261
		[Token(Token = "0x4029CFD")]
		[FieldOffset(Offset = "0x44")]
		public PlayerRoguelikeZoneType zoneType;

		// Token: 0x04029CFE RID: 171262
		[Token(Token = "0x4029CFE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curNode;

		// Token: 0x04029CFF RID: 171263
		[Token(Token = "0x4029CFF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029D00 RID: 171264
		[Token(Token = "0x4029D00")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckAndSetZoneDiffDisplay;

		// Token: 0x04029D01 RID: 171265
		[Token(Token = "0x4029D01")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
