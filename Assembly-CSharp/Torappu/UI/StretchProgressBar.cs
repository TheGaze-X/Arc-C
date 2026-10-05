using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039C3 RID: 14787
	[Token(Token = "0x20039C3")]
	public class StretchProgressBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x060175C7 RID: 95687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175C7")]
		[Address(RVA = "0xFB89D0", Offset = "0xFB75D0", VA = "0x180FB89D0")]
		private void Start()
		{
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x060175C8 RID: 95688 RVA: 0x000962A0 File Offset: 0x000944A0
		// (set) Token: 0x060175C9 RID: 95689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037F1")]
		[Inspect(InspectorLevel.Debug)]
		public float progress
		{
			[Token(Token = "0x60175C8")]
			[Address(RVA = "0xFB8C40", Offset = "0xFB7840", VA = "0x180FB8C40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60175C9")]
			[Address(RVA = "0xFB8CA0", Offset = "0xFB78A0", VA = "0x180FB8CA0")]
			set
			{
			}
		}

		// Token: 0x060175CA RID: 95690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175CA")]
		[Address(RVA = "0xFB8A30", Offset = "0xFB7630", VA = "0x180FB8A30")]
		private void _UpdateProgress()
		{
		}

		// Token: 0x060175CB RID: 95691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175CB")]
		[Address(RVA = "0xFB8BE0", Offset = "0xFB77E0", VA = "0x180FB8BE0")]
		public StretchProgressBar()
		{
		}

		// Token: 0x0401C355 RID: 115541
		[Token(Token = "0x401C355")]
		private const float FULL_THRESHOLD = 0.99f;

		// Token: 0x0401C356 RID: 115542
		[Token(Token = "0x401C356")]
		private const float EMPTY_THRESHOLD = 0.01f;

		// Token: 0x0401C357 RID: 115543
		[Token(Token = "0x401C357")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("the background of the progress bar")]
		private RectTransform _emptyBar;

		// Token: 0x0401C358 RID: 115544
		[Token(Token = "0x401C358")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("the bar to stretch representing the progress")]
		private RectTransform _stretchBar;

		// Token: 0x0401C359 RID: 115545
		[Token(Token = "0x401C359")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Nullable, the bar when progress is full")]
		private RectTransform _fullBar;

		// Token: 0x0401C35A RID: 115546
		[Token(Token = "0x401C35A")]
		[FieldOffset(Offset = "0x30")]
		private float m_progress;

		// Token: 0x0401C35B RID: 115547
		[Token(Token = "0x401C35B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401C35C RID: 115548
		[Token(Token = "0x401C35C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x0401C35D RID: 115549
		[Token(Token = "0x401C35D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_progress;

		// Token: 0x0401C35E RID: 115550
		[Token(Token = "0x401C35E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateProgress;

		// Token: 0x0401C35F RID: 115551
		[Token(Token = "0x401C35F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
