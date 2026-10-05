using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078C2 RID: 30914
	[Token(Token = "0x20078C2")]
	public class Act1LockStageBtnHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006570 RID: 25968
		// (get) Token: 0x0602B5AB RID: 177579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006570")]
		protected RectTransform buttonContainer
		{
			[Token(Token = "0x602B5AB")]
			[Address(RVA = "0x2731AA0", Offset = "0x27306A0", VA = "0x182731AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B5AC RID: 177580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5AC")]
		[Address(RVA = "0x2731130", Offset = "0x272FD30", VA = "0x182731130")]
		public void SetupIfNeeded([Optional] Act1LockStageBtn defaultPrefab, bool anyInterLockUnlocked = false)
		{
		}

		// Token: 0x0602B5AD RID: 177581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5AD")]
		[Address(RVA = "0x27318A0", Offset = "0x27304A0", VA = "0x1827318A0")]
		private void _SetHolderStatus(bool interLockUnlocked = false)
		{
		}

		// Token: 0x17006571 RID: 25969
		// (get) Token: 0x0602B5AE RID: 177582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006571")]
		public Act1LockStageBtn button
		{
			[Token(Token = "0x602B5AE")]
			[Address(RVA = "0x2731B50", Offset = "0x2730750", VA = "0x182731B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006572 RID: 25970
		// (get) Token: 0x0602B5AF RID: 177583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006572")]
		public string stageId
		{
			[Token(Token = "0x602B5AF")]
			[Address(RVA = "0x2731BB0", Offset = "0x27307B0", VA = "0x182731BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B5B0 RID: 177584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5B0")]
		[Address(RVA = "0x2731530", Offset = "0x2730130", VA = "0x182731530")]
		public void TryPlayAnimation(bool isFinalFirst, bool isInterlockFirst)
		{
		}

		// Token: 0x0602B5B1 RID: 177585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5B1")]
		[Address(RVA = "0x2731A40", Offset = "0x2730640", VA = "0x182731A40")]
		public Act1LockStageBtnHolder()
		{
		}

		// Token: 0x0403EB15 RID: 256789
		[Token(Token = "0x403EB15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1LockStageBtn _prefab;

		// Token: 0x0403EB16 RID: 256790
		[Token(Token = "0x403EB16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0403EB17 RID: 256791
		[Token(Token = "0x403EB17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _stageId;

		// Token: 0x0403EB18 RID: 256792
		[Token(Token = "0x403EB18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403EB19 RID: 256793
		[Token(Token = "0x403EB19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2 originPosition;

		// Token: 0x0403EB1A RID: 256794
		[Token(Token = "0x403EB1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2 advancedPosition;

		// Token: 0x0403EB1B RID: 256795
		[Token(Token = "0x403EB1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Act1LockStageBtn m_button;

		// Token: 0x0403EB1C RID: 256796
		[Token(Token = "0x403EB1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_appliedPrefabSign;

		// Token: 0x0403EB1D RID: 256797
		[Token(Token = "0x403EB1D")]
		private const float ALPHA_ZERO = 0f;

		// Token: 0x0403EB1E RID: 256798
		[Token(Token = "0x403EB1E")]
		private const float ALPHA_ONE = 1f;

		// Token: 0x0403EB1F RID: 256799
		[Token(Token = "0x403EB1F")]
		private const float TWEENER_DURATION = 1f;

		// Token: 0x0403EB20 RID: 256800
		[Token(Token = "0x403EB20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buttonContainer;

		// Token: 0x0403EB21 RID: 256801
		[Token(Token = "0x403EB21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetupIfNeeded;

		// Token: 0x0403EB22 RID: 256802
		[Token(Token = "0x403EB22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetHolderStatus;

		// Token: 0x0403EB23 RID: 256803
		[Token(Token = "0x403EB23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_button;

		// Token: 0x0403EB24 RID: 256804
		[Token(Token = "0x403EB24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0403EB25 RID: 256805
		[Token(Token = "0x403EB25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryPlayAnimation;

		// Token: 0x0403EB26 RID: 256806
		[Token(Token = "0x403EB26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
