using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047C6 RID: 18374
	[Token(Token = "0x20047C6")]
	public class RecalRuneStageRuneView : DataBinder<RecalRuneStageRuneProperty>
	{
		// Token: 0x17004224 RID: 16932
		// (get) Token: 0x0601BD04 RID: 113924 RVA: 0x000A6590 File Offset: 0x000A4790
		// (set) Token: 0x0601BD05 RID: 113925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004224")]
		public bool fastMode
		{
			[Token(Token = "0x601BD04")]
			[Address(RVA = "0x1534EC0", Offset = "0x1533AC0", VA = "0x181534EC0")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x601BD05")]
			[Address(RVA = "0x1534F20", Offset = "0x1533B20", VA = "0x181534F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BD06 RID: 113926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD06")]
		[Address(RVA = "0x1534AC0", Offset = "0x15336C0", VA = "0x181534AC0", Slot = "7")]
		public override void OnValueChanged(RecalRuneStageRuneProperty property)
		{
		}

		// Token: 0x0601BD07 RID: 113927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD07")]
		[Address(RVA = "0x1534D40", Offset = "0x1533940", VA = "0x181534D40")]
		public void RegisterTutorialObjects()
		{
		}

		// Token: 0x0601BD08 RID: 113928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD08")]
		[Address(RVA = "0x1534E50", Offset = "0x1533A50", VA = "0x181534E50")]
		public RecalRuneStageRuneView()
		{
		}

		// Token: 0x040242FF RID: 148223
		[Token(Token = "0x40242FF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RecalRuneStageRuneTopView _topView;

		// Token: 0x04024300 RID: 148224
		[Token(Token = "0x4024300")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RecalRuneStageRuneSelectView _selectView;

		// Token: 0x04024301 RID: 148225
		[Token(Token = "0x4024301")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RecalRuneStageRunePackView _packView;

		// Token: 0x04024302 RID: 148226
		[Token(Token = "0x4024302")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RecalRuneStageRuneBottomView _bottomView;

		// Token: 0x04024303 RID: 148227
		[Token(Token = "0x4024303")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _tutorial_selectPart;

		// Token: 0x04024304 RID: 148228
		[Token(Token = "0x4024304")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _tutorial_infoPart;

		// Token: 0x04024306 RID: 148230
		[Token(Token = "0x4024306")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fastMode;

		// Token: 0x04024307 RID: 148231
		[Token(Token = "0x4024307")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_fastMode;

		// Token: 0x04024308 RID: 148232
		[Token(Token = "0x4024308")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024309 RID: 148233
		[Token(Token = "0x4024309")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterTutorialObjects;

		// Token: 0x0402430A RID: 148234
		[Token(Token = "0x402430A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
