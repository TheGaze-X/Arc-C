using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023B4 RID: 9140
	[Token(Token = "0x20023B4")]
	public class TileBasedColorController : SingletonMonoBehaviour<TileBasedColorController>
	{
		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x0600E859 RID: 59481 RVA: 0x00054CC0 File Offset: 0x00052EC0
		[Token(Token = "0x17001D50")]
		private int m_width
		{
			[Token(Token = "0x600E859")]
			[Address(RVA = "0x5DCAD0", Offset = "0x5DB6D0", VA = "0x1805DCAD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x0600E85A RID: 59482 RVA: 0x00054CD8 File Offset: 0x00052ED8
		[Token(Token = "0x17001D51")]
		private int m_height
		{
			[Token(Token = "0x600E85A")]
			[Address(RVA = "0x5DCA10", Offset = "0x5DB610", VA = "0x1805DCA10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600E85B RID: 59483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E85B")]
		[Address(RVA = "0x5DBF20", Offset = "0x5DAB20", VA = "0x1805DBF20")]
		public void Init(Map map)
		{
		}

		// Token: 0x0600E85C RID: 59484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E85C")]
		[Address(RVA = "0x5DC3D0", Offset = "0x5DAFD0", VA = "0x1805DC3D0")]
		public void SetColor(GridPosition gridPos, Color color)
		{
		}

		// Token: 0x0600E85D RID: 59485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E85D")]
		[Address(RVA = "0x5DC7E0", Offset = "0x5DB3E0", VA = "0x1805DC7E0")]
		private Texture2D _CreateTextureInternal(int width, int height, Color[] colors)
		{
			return null;
		}

		// Token: 0x0600E85E RID: 59486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E85E")]
		[Address(RVA = "0x5DC910", Offset = "0x5DB510", VA = "0x1805DC910")]
		private void _UpdateTexture()
		{
		}

		// Token: 0x0600E85F RID: 59487 RVA: 0x00054CF0 File Offset: 0x00052EF0
		[Token(Token = "0x600E85F")]
		[Address(RVA = "0x5DC680", Offset = "0x5DB280", VA = "0x1805DC680")]
		private bool _CheckGridPosValid(GridPosition gridPos)
		{
			return default(bool);
		}

		// Token: 0x0600E860 RID: 59488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E860")]
		[Address(RVA = "0x5DC1F0", Offset = "0x5DADF0", VA = "0x1805DC1F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600E861 RID: 59489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E861")]
		[Address(RVA = "0x5DC2B0", Offset = "0x5DAEB0", VA = "0x1805DC2B0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600E862 RID: 59490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E862")]
		[Address(RVA = "0x5DC9A0", Offset = "0x5DB5A0", VA = "0x1805DC9A0")]
		public TileBasedColorController()
		{
		}

		// Token: 0x0400FFF4 RID: 65524
		[Token(Token = "0x400FFF4")]
		private const string COLOR_TEXTURE_NAME = "TileBasedColorTexture";

		// Token: 0x0400FFF5 RID: 65525
		[Token(Token = "0x400FFF5")]
		[FieldOffset(Offset = "0x18")]
		private Texture2D m_colorTexture;

		// Token: 0x0400FFF6 RID: 65526
		[Token(Token = "0x400FFF6")]
		[FieldOffset(Offset = "0x20")]
		private Vector4 m_mapParams;

		// Token: 0x0400FFF7 RID: 65527
		[Token(Token = "0x400FFF7")]
		[FieldOffset(Offset = "0x30")]
		private Color[] m_colors;

		// Token: 0x0400FFF8 RID: 65528
		[Token(Token = "0x400FFF8")]
		[FieldOffset(Offset = "0x38")]
		private bool m_colorDirty;

		// Token: 0x0400FFF9 RID: 65529
		[Token(Token = "0x400FFF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_m_width;

		// Token: 0x0400FFFA RID: 65530
		[Token(Token = "0x400FFFA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_m_height;

		// Token: 0x0400FFFB RID: 65531
		[Token(Token = "0x400FFFB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FFFC RID: 65532
		[Token(Token = "0x400FFFC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetColor;

		// Token: 0x0400FFFD RID: 65533
		[Token(Token = "0x400FFFD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateTextureInternal;

		// Token: 0x0400FFFE RID: 65534
		[Token(Token = "0x400FFFE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateTexture;

		// Token: 0x0400FFFF RID: 65535
		[Token(Token = "0x400FFFF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckGridPosValid;

		// Token: 0x04010000 RID: 65536
		[Token(Token = "0x4010000")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x04010001 RID: 65537
		[Token(Token = "0x4010001")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04010002 RID: 65538
		[Token(Token = "0x4010002")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
