using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056A3 RID: 22179
	[Token(Token = "0x20056A3")]
	public class RL04ZoneFragmentDialogPlugin : RoguelikeTopicDialogPlugin
	{
		// Token: 0x06020878 RID: 133240 RVA: 0x000B6538 File Offset: 0x000B4738
		[Token(Token = "0x6020878")]
		[Address(RVA = "0x1AB7550", Offset = "0x1AB6150", VA = "0x181AB7550", Slot = "4")]
		public override KeyValuePair<string, RoguelikeDialogMgr> GetDialogMgr()
		{
			return default(KeyValuePair<string, RoguelikeDialogMgr>);
		}

		// Token: 0x06020879 RID: 133241 RVA: 0x000B6550 File Offset: 0x000B4750
		[Token(Token = "0x6020879")]
		[Address(RVA = "0x1AB7690", Offset = "0x1AB6290", VA = "0x181AB7690")]
		private static bool _CheckFragmentGainFlag()
		{
			return default(bool);
		}

		// Token: 0x0602087A RID: 133242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602087A")]
		[Address(RVA = "0x1AB77C0", Offset = "0x1AB63C0", VA = "0x181AB77C0")]
		private static List<RoguelikeFragmentGainItem> _GetFragmentList(string topicId)
		{
			return null;
		}

		// Token: 0x0602087B RID: 133243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602087B")]
		[Address(RVA = "0x1AB7BF0", Offset = "0x1AB67F0", VA = "0x181AB7BF0")]
		private static IEnumerator _ShowFragmentGainDialog(UICompDialogMgr compDialogMgr, string topicId)
		{
			return null;
		}

		// Token: 0x0602087C RID: 133244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602087C")]
		[Address(RVA = "0x1AB7CC0", Offset = "0x1AB68C0", VA = "0x181AB7CC0")]
		public RL04ZoneFragmentDialogPlugin()
		{
		}

		// Token: 0x0402C142 RID: 180546
		[Token(Token = "0x402C142")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x0402C143 RID: 180547
		[Token(Token = "0x402C143")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckFragmentGainFlag;

		// Token: 0x0402C144 RID: 180548
		[Token(Token = "0x402C144")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetFragmentList;

		// Token: 0x0402C145 RID: 180549
		[Token(Token = "0x402C145")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowFragmentGainDialog;

		// Token: 0x0402C146 RID: 180550
		[Token(Token = "0x402C146")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056A4 RID: 22180
		[Token(Token = "0x20056A4")]
		public class FragmentDialogMgr : RoguelikeDialogMgr
		{
			// Token: 0x0602087D RID: 133245 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602087D")]
			[Address(RVA = "0x1AA4040", Offset = "0x1AA2C40", VA = "0x181AA4040", Slot = "4")]
			public override IEnumerator OnShowDialog(UICompDialogMgr compDialogMgr, string topicId)
			{
				return null;
			}

			// Token: 0x0602087E RID: 133246 RVA: 0x000B6568 File Offset: 0x000B4768
			[Token(Token = "0x602087E")]
			[Address(RVA = "0x1AA3D90", Offset = "0x1AA2990", VA = "0x181AA3D90", Slot = "5")]
			public override bool OnCheckNeedShowDialog(string topicId, List<SortableString> sortableList)
			{
				return default(bool);
			}

			// Token: 0x0602087F RID: 133247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602087F")]
			[Address(RVA = "0x1AA4120", Offset = "0x1AA2D20", VA = "0x181AA4120")]
			public FragmentDialogMgr()
			{
			}

			// Token: 0x0402C147 RID: 180551
			[Token(Token = "0x402C147")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnShowDialog;

			// Token: 0x0402C148 RID: 180552
			[Token(Token = "0x402C148")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnCheckNeedShowDialog;

			// Token: 0x0402C149 RID: 180553
			[Token(Token = "0x402C149")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
