using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm
{
	// Token: 0x02004005 RID: 16389
	[Token(Token = "0x2004005")]
	public abstract class SandboxPermHomeControllerBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x06019603 RID: 103939 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019604 RID: 103940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C82")]
		public SandboxPermHomeState bindState
		{
			[Token(Token = "0x6019603")]
			[Address(RVA = "0x1216B40", Offset = "0x1215740", VA = "0x181216B40")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6019604")]
			[Address(RVA = "0x1216BA0", Offset = "0x12157A0", VA = "0x181216BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019605 RID: 103941
		[Token(Token = "0x6019605")]
		public abstract void Init(string topicId);

		// Token: 0x06019606 RID: 103942
		[Token(Token = "0x6019606")]
		public abstract string GetTopicId();

		// Token: 0x06019607 RID: 103943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019607")]
		[Address(RVA = "0x1216A80", Offset = "0x1215680", VA = "0x181216A80", Slot = "6")]
		public virtual void OnResume(bool isResumedFromStack)
		{
		}

		// Token: 0x06019608 RID: 103944
		[Token(Token = "0x6019608")]
		public abstract Canvas[] GetNeedBindCanvas();

		// Token: 0x06019609 RID: 103945
		[Token(Token = "0x6019609")]
		public abstract UICommonPageEffectHolder[] GetNeedBindEffectHolders();

		// Token: 0x0601960A RID: 103946
		[Token(Token = "0x601960A")]
		public abstract string GetMedalGroupId();

		// Token: 0x0601960B RID: 103947
		[Token(Token = "0x601960B")]
		public abstract Coroutine PageOnlyStartShowEffects(bool fastMode, bool backFromBattle);

		// Token: 0x0601960C RID: 103948
		[Token(Token = "0x601960C")]
		public abstract void PageOnlyDisposeEffects();

		// Token: 0x0601960D RID: 103949
		[Token(Token = "0x601960D")]
		public abstract bool CheckIfUseFastEnter();

		// Token: 0x0601960E RID: 103950
		[Token(Token = "0x601960E")]
		public abstract SandboxPermHomePage.DisplayTweenConfig GetDisplayTweenConfig(bool fastMode);

		// Token: 0x0601960F RID: 103951 RVA: 0x0009DDB8 File Offset: 0x0009BFB8
		[Token(Token = "0x601960F")]
		[Address(RVA = "0x1216A20", Offset = "0x1215620", VA = "0x181216A20", Slot = "14")]
		public virtual bool OnPageBackPressBtnClick()
		{
			return default(bool);
		}

		// Token: 0x06019610 RID: 103952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019610")]
		[Address(RVA = "0x1216990", Offset = "0x1215590", VA = "0x181216990", Slot = "15")]
		public virtual void HandleCompDialogCallback(int instId, ValueBundle output)
		{
		}

		// Token: 0x06019611 RID: 103953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019611")]
		protected void OpenCompDialog<TDialog, TInput>(string resPath, TInput options, out int dialogInstId) where TDialog : UICompDialog<TInput> where TInput : class
		{
		}

		// Token: 0x06019612 RID: 103954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019612")]
		[Address(RVA = "0x1216AE0", Offset = "0x12156E0", VA = "0x181216AE0")]
		protected SandboxPermHomeControllerBase()
		{
		}

		// Token: 0x0401F931 RID: 129329
		[Token(Token = "0x401F931")]
		[FieldOffset(Offset = "0x18")]
		protected UIStateFinder stateFinder;

		// Token: 0x0401F933 RID: 129331
		[Token(Token = "0x401F933")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindState;

		// Token: 0x0401F934 RID: 129332
		[Token(Token = "0x401F934")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindState;

		// Token: 0x0401F935 RID: 129333
		[Token(Token = "0x401F935")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401F936 RID: 129334
		[Token(Token = "0x401F936")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPageBackPressBtnClick;

		// Token: 0x0401F937 RID: 129335
		[Token(Token = "0x401F937")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCompDialogCallback;

		// Token: 0x0401F938 RID: 129336
		[Token(Token = "0x401F938")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OpenCompDialog;

		// Token: 0x0401F939 RID: 129337
		[Token(Token = "0x401F939")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
