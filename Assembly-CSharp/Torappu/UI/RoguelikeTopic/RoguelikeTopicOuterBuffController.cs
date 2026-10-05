using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200452A RID: 17706
	[Token(Token = "0x200452A")]
	public abstract class RoguelikeTopicOuterBuffController : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700403C RID: 16444
		// (get) Token: 0x0601B00B RID: 110603 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B00C RID: 110604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700403C")]
		public Action closeOuterBuffState
		{
			[Token(Token = "0x601B00B")]
			[Address(RVA = "0x142C750", Offset = "0x142B350", VA = "0x18142C750")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B00C")]
			[Address(RVA = "0x142C7B0", Offset = "0x142B3B0", VA = "0x18142C7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B00D RID: 110605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B00D")]
		[Address(RVA = "0x141ACC0", Offset = "0x14198C0", VA = "0x18141ACC0", Slot = "4")]
		public virtual void Init()
		{
		}

		// Token: 0x0601B00E RID: 110606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B00E")]
		[Address(RVA = "0x141AD20", Offset = "0x1419920", VA = "0x18141AD20", Slot = "5")]
		public virtual void OnEnter(string topicId)
		{
		}

		// Token: 0x0601B00F RID: 110607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B00F")]
		[Address(RVA = "0x141AD80", Offset = "0x1419980", VA = "0x18141AD80", Slot = "6")]
		public virtual void OnResume(bool isResumedFromStack)
		{
		}

		// Token: 0x0601B010 RID: 110608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B010")]
		[Address(RVA = "0x142C400", Offset = "0x142B000", VA = "0x18142C400", Slot = "7")]
		public virtual void OnExit()
		{
		}

		// Token: 0x0601B011 RID: 110609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B011")]
		[Address(RVA = "0x142C3A0", Offset = "0x142AFA0", VA = "0x18142C3A0", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0601B012 RID: 110610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B012")]
		[Address(RVA = "0x142C570", Offset = "0x142B170", VA = "0x18142C570")]
		protected static CommonTopMenu _CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0601B013 RID: 110611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B013")]
		[Address(RVA = "0x142C460", Offset = "0x142B060", VA = "0x18142C460")]
		protected void _CloseOuterBuffState()
		{
		}

		// Token: 0x0601B014 RID: 110612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B014")]
		[Address(RVA = "0x142C6F0", Offset = "0x142B2F0", VA = "0x18142C6F0")]
		protected RoguelikeTopicOuterBuffController()
		{
		}

		// Token: 0x04022AF2 RID: 142066
		[Token(Token = "0x4022AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public UIPage page;

		// Token: 0x04022AF4 RID: 142068
		[Token(Token = "0x4022AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_closeOuterBuffState;

		// Token: 0x04022AF5 RID: 142069
		[Token(Token = "0x4022AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_closeOuterBuffState;

		// Token: 0x04022AF6 RID: 142070
		[Token(Token = "0x4022AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022AF7 RID: 142071
		[Token(Token = "0x4022AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04022AF8 RID: 142072
		[Token(Token = "0x4022AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04022AF9 RID: 142073
		[Token(Token = "0x4022AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04022AFA RID: 142074
		[Token(Token = "0x4022AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04022AFB RID: 142075
		[Token(Token = "0x4022AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateCommonTopMenu;

		// Token: 0x04022AFC RID: 142076
		[Token(Token = "0x4022AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CloseOuterBuffState;

		// Token: 0x04022AFD RID: 142077
		[Token(Token = "0x4022AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
