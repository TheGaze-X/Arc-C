using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052C2 RID: 21186
	[Token(Token = "0x20052C2")]
	public abstract class RoguelikeEndingControllerBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004943 RID: 18755
		// (get) Token: 0x0601F3E7 RID: 127975 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F3E8 RID: 127976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004943")]
		public RoguelikeEndingState state
		{
			[Token(Token = "0x601F3E7")]
			[Address(RVA = "0x18F8410", Offset = "0x18F7010", VA = "0x1818F8410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F3E8")]
			[Address(RVA = "0x18F84D0", Offset = "0x18F70D0", VA = "0x1818F84D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004944 RID: 18756
		// (get) Token: 0x0601F3E9 RID: 127977 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F3EA RID: 127978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004944")]
		public string topicId
		{
			[Token(Token = "0x601F3E9")]
			[Address(RVA = "0x18F8470", Offset = "0x18F7070", VA = "0x1818F8470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F3EA")]
			[Address(RVA = "0x18F8550", Offset = "0x18F7150", VA = "0x1818F8550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601F3EB RID: 127979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3EB")]
		[Address(RVA = "0x18F8070", Offset = "0x18F6C70", VA = "0x1818F8070")]
		public void Init(RoguelikeEndingState state, string topicId, RoguelikeEndingViewModel viewModel)
		{
		}

		// Token: 0x0601F3EC RID: 127980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3EC")]
		[Address(RVA = "0x18F8270", Offset = "0x18F6E70", VA = "0x1818F8270")]
		public void NotifyOnResume()
		{
		}

		// Token: 0x0601F3ED RID: 127981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3ED")]
		[Address(RVA = "0x18F81F0", Offset = "0x18F6DF0", VA = "0x1818F81F0")]
		public void NotifyExit()
		{
		}

		// Token: 0x0601F3EE RID: 127982
		[Token(Token = "0x601F3EE")]
		protected abstract void SetEndingViewModel(RoguelikeEndingViewModel viewModel);

		// Token: 0x0601F3EF RID: 127983
		[Token(Token = "0x601F3EF")]
		public abstract RoguelikeEndingViewModel ConstructViewModel(RoguelikeTopicMode mode);

		// Token: 0x0601F3F0 RID: 127984
		[Token(Token = "0x601F3F0")]
		protected abstract void OnInit();

		// Token: 0x0601F3F1 RID: 127985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3F1")]
		[Address(RVA = "0x18F8350", Offset = "0x18F6F50", VA = "0x1818F8350", Slot = "7")]
		protected virtual void OnResume()
		{
		}

		// Token: 0x0601F3F2 RID: 127986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3F2")]
		[Address(RVA = "0x18F82F0", Offset = "0x18F6EF0", VA = "0x1818F82F0", Slot = "8")]
		protected virtual void OnExit()
		{
		}

		// Token: 0x0601F3F3 RID: 127987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3F3")]
		[Address(RVA = "0x18F83B0", Offset = "0x18F6FB0", VA = "0x1818F83B0")]
		protected RoguelikeEndingControllerBase()
		{
		}

		// Token: 0x04029F7C RID: 171900
		[Token(Token = "0x4029F7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x04029F7D RID: 171901
		[Token(Token = "0x4029F7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x04029F7E RID: 171902
		[Token(Token = "0x4029F7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04029F7F RID: 171903
		[Token(Token = "0x4029F7F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04029F80 RID: 171904
		[Token(Token = "0x4029F80")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04029F81 RID: 171905
		[Token(Token = "0x4029F81")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifyOnResume;

		// Token: 0x04029F82 RID: 171906
		[Token(Token = "0x4029F82")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyExit;

		// Token: 0x04029F83 RID: 171907
		[Token(Token = "0x4029F83")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04029F84 RID: 171908
		[Token(Token = "0x4029F84")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04029F85 RID: 171909
		[Token(Token = "0x4029F85")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
