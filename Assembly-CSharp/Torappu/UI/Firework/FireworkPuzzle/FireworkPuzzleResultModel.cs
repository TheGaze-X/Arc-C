using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E6F RID: 20079
	[Token(Token = "0x2004E6F")]
	public class FireworkPuzzleResultModel : IHotfixable
	{
		// Token: 0x17004656 RID: 18006
		// (get) Token: 0x0601DF78 RID: 122744 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DF79 RID: 122745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004656")]
		public FireworkPlateModel plateModel
		{
			[Token(Token = "0x601DF78")]
			[Address(RVA = "0x17AC6B0", Offset = "0x17AB2B0", VA = "0x1817AC6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601DF79")]
			[Address(RVA = "0x17AC7E0", Offset = "0x17AB3E0", VA = "0x1817AC7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004657 RID: 18007
		// (get) Token: 0x0601DF7A RID: 122746 RVA: 0x000AD0A0 File Offset: 0x000AB2A0
		// (set) Token: 0x0601DF7B RID: 122747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004657")]
		public int enterSeqNum
		{
			[Token(Token = "0x601DF7A")]
			[Address(RVA = "0x17AC650", Offset = "0x17AB250", VA = "0x1817AC650")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601DF7B")]
			[Address(RVA = "0x17AC770", Offset = "0x17AB370", VA = "0x1817AC770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004658 RID: 18008
		// (get) Token: 0x0601DF7C RID: 122748 RVA: 0x000AD0B8 File Offset: 0x000AB2B8
		// (set) Token: 0x0601DF7D RID: 122749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004658")]
		public bool showReward
		{
			[Token(Token = "0x601DF7C")]
			[Address(RVA = "0x17AC710", Offset = "0x17AB310", VA = "0x1817AC710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601DF7D")]
			[Address(RVA = "0x17AC860", Offset = "0x17AB460", VA = "0x1817AC860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601DF7E RID: 122750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF7E")]
		[Address(RVA = "0x17AC440", Offset = "0x17AB040", VA = "0x1817AC440")]
		public void MarkEnter()
		{
		}

		// Token: 0x0601DF7F RID: 122751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF7F")]
		[Address(RVA = "0x17AC2F0", Offset = "0x17AAEF0", VA = "0x1817AC2F0")]
		public void LoadData(string actId, FireworkPlateModel cachePlateModel, bool isFirstComplete)
		{
		}

		// Token: 0x0601DF80 RID: 122752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF80")]
		[Address(RVA = "0x17AC540", Offset = "0x17AB140", VA = "0x1817AC540")]
		public FireworkNpcDialogModel RandomDialog()
		{
			return null;
		}

		// Token: 0x0601DF81 RID: 122753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF81")]
		[Address(RVA = "0x17AC5B0", Offset = "0x17AB1B0", VA = "0x1817AC5B0")]
		public FireworkPuzzleResultModel()
		{
		}

		// Token: 0x04027CC3 RID: 163011
		[Token(Token = "0x4027CC3")]
		[FieldOffset(Offset = "0x10")]
		private FireworkNpcModel m_npcModel;

		// Token: 0x04027CC7 RID: 163015
		[Token(Token = "0x4027CC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_plateModel;

		// Token: 0x04027CC8 RID: 163016
		[Token(Token = "0x4027CC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_plateModel;

		// Token: 0x04027CC9 RID: 163017
		[Token(Token = "0x4027CC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enterSeqNum;

		// Token: 0x04027CCA RID: 163018
		[Token(Token = "0x4027CCA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_enterSeqNum;

		// Token: 0x04027CCB RID: 163019
		[Token(Token = "0x4027CCB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_showReward;

		// Token: 0x04027CCC RID: 163020
		[Token(Token = "0x4027CCC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_showReward;

		// Token: 0x04027CCD RID: 163021
		[Token(Token = "0x4027CCD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_MarkEnter;

		// Token: 0x04027CCE RID: 163022
		[Token(Token = "0x4027CCE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027CCF RID: 163023
		[Token(Token = "0x4027CCF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RandomDialog;

		// Token: 0x04027CD0 RID: 163024
		[Token(Token = "0x4027CD0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
