using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200411E RID: 16670
	[Token(Token = "0x200411E")]
	public abstract class SandboxV2FloatPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x06019C1F RID: 105503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D65")]
		public List<Transform> rootTransformList
		{
			[Token(Token = "0x6019C1F")]
			[Address(RVA = "0x1298FB0", Offset = "0x1297BB0", VA = "0x181298FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003D66 RID: 15718
		// (get) Token: 0x06019C20 RID: 105504 RVA: 0x0009F510 File Offset: 0x0009D710
		// (set) Token: 0x06019C21 RID: 105505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D66")]
		public bool isShow
		{
			[Token(Token = "0x6019C20")]
			[Address(RVA = "0x1298F50", Offset = "0x1297B50", VA = "0x181298F50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019C21")]
			[Address(RVA = "0x1299010", Offset = "0x1297C10", VA = "0x181299010")]
			set
			{
			}
		}

		// Token: 0x06019C22 RID: 105506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C22")]
		[Address(RVA = "0x1298DF0", Offset = "0x12979F0", VA = "0x181298DF0")]
		private void _DoSetShowStatus(bool isShow)
		{
		}

		// Token: 0x06019C23 RID: 105507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C23")]
		[Address(RVA = "0x1298CE0", Offset = "0x12978E0", VA = "0x181298CE0")]
		public void Reset(bool isShow)
		{
		}

		// Token: 0x06019C24 RID: 105508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C24")]
		[Address(RVA = "0x1298850", Offset = "0x1297450", VA = "0x181298850")]
		private void Awake()
		{
		}

		// Token: 0x06019C25 RID: 105509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C25")]
		[Address(RVA = "0x1298BB0", Offset = "0x12977B0", VA = "0x181298BB0")]
		private void OnEnable()
		{
		}

		// Token: 0x06019C26 RID: 105510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C26")]
		[Address(RVA = "0x1298A00", Offset = "0x1297600", VA = "0x181298A00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06019C27 RID: 105511
		[Token(Token = "0x6019C27")]
		protected abstract void SetShowStatus(bool isShow, bool fastMode = false);

		// Token: 0x06019C28 RID: 105512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C28")]
		[Address(RVA = "0x1298EF0", Offset = "0x1297AF0", VA = "0x181298EF0")]
		protected SandboxV2FloatPanel()
		{
		}

		// Token: 0x0402048F RID: 132239
		[Token(Token = "0x402048F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Transform> _rootTransformList;

		// Token: 0x04020490 RID: 132240
		[Token(Token = "0x4020490")]
		[FieldOffset(Offset = "0x20")]
		private bool m_showStatus;

		// Token: 0x04020491 RID: 132241
		[Token(Token = "0x4020491")]
		[FieldOffset(Offset = "0x28")]
		private SandboxV2FloatPanelManager m_floatPanelManager;

		// Token: 0x04020492 RID: 132242
		[Token(Token = "0x4020492")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rootTransformList;

		// Token: 0x04020493 RID: 132243
		[Token(Token = "0x4020493")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04020494 RID: 132244
		[Token(Token = "0x4020494")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x04020495 RID: 132245
		[Token(Token = "0x4020495")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoSetShowStatus;

		// Token: 0x04020496 RID: 132246
		[Token(Token = "0x4020496")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04020497 RID: 132247
		[Token(Token = "0x4020497")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04020498 RID: 132248
		[Token(Token = "0x4020498")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04020499 RID: 132249
		[Token(Token = "0x4020499")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402049A RID: 132250
		[Token(Token = "0x402049A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
