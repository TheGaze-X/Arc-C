using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200415D RID: 16733
	[Token(Token = "0x200415D")]
	public class SandboxV2DungeonCullElement : MonoBehaviour, ISandboxV2DungeonCullElement, IHotfixable
	{
		// Token: 0x06019D57 RID: 105815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D57")]
		[Address(RVA = "0x12B2470", Offset = "0x12B1070", VA = "0x1812B2470")]
		private void OnEnable()
		{
		}

		// Token: 0x06019D58 RID: 105816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D58")]
		[Address(RVA = "0x12B2360", Offset = "0x12B0F60", VA = "0x1812B2360")]
		private void OnDisable()
		{
		}

		// Token: 0x06019D59 RID: 105817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019D59")]
		[Address(RVA = "0x12B20C0", Offset = "0x12B0CC0", VA = "0x1812B20C0", Slot = "5")]
		public CanvasGroup GetAlphaHandler()
		{
			return null;
		}

		// Token: 0x06019D5A RID: 105818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019D5A")]
		[Address(RVA = "0x12B2120", Offset = "0x12B0D20", VA = "0x1812B2120", Slot = "4")]
		public Vector3[] GetWorldCullBounds()
		{
			return null;
		}

		// Token: 0x06019D5B RID: 105819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D5B")]
		[Address(RVA = "0x12B25E0", Offset = "0x12B11E0", VA = "0x1812B25E0")]
		public SandboxV2DungeonCullElement()
		{
		}

		// Token: 0x04020717 RID: 132887
		[Token(Token = "0x4020717")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04020718 RID: 132888
		[Token(Token = "0x4020718")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _boundOffsetMax;

		// Token: 0x04020719 RID: 132889
		[Token(Token = "0x4020719")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _boundOffsetMin;

		// Token: 0x0402071A RID: 132890
		[Token(Token = "0x402071A")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2DungeonCullController m_cullController;

		// Token: 0x0402071B RID: 132891
		[Token(Token = "0x402071B")]
		[FieldOffset(Offset = "0x38")]
		private Vector3[] m_worldCullBounds;

		// Token: 0x0402071C RID: 132892
		[Token(Token = "0x402071C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402071D RID: 132893
		[Token(Token = "0x402071D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0402071E RID: 132894
		[Token(Token = "0x402071E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetAlphaHandler;

		// Token: 0x0402071F RID: 132895
		[Token(Token = "0x402071F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetWorldCullBounds;

		// Token: 0x04020720 RID: 132896
		[Token(Token = "0x4020720")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
