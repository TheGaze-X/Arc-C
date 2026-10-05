using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E41 RID: 20033
	[Token(Token = "0x2004E41")]
	[CreateAssetMenu(menuName = "Torappu/Firework/FireworkPlateViewStyle")]
	public class FireworkPlateViewStyle : ScriptableObject, IHotfixable
	{
		// Token: 0x1700463B RID: 17979
		// (get) Token: 0x0601DEAF RID: 122543 RVA: 0x000ACDB8 File Offset: 0x000AAFB8
		[Token(Token = "0x1700463B")]
		public Color bkgOutlineColor
		{
			[Token(Token = "0x601DEAF")]
			[Address(RVA = "0x1771880", Offset = "0x1770480", VA = "0x181771880")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700463C RID: 17980
		// (get) Token: 0x0601DEB0 RID: 122544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700463C")]
		public Color[] gridBkgColors
		{
			[Token(Token = "0x601DEB0")]
			[Address(RVA = "0x1771A60", Offset = "0x1770660", VA = "0x181771A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700463D RID: 17981
		// (get) Token: 0x0601DEB1 RID: 122545 RVA: 0x000ACDD0 File Offset: 0x000AAFD0
		[Token(Token = "0x1700463D")]
		public Color centerMarkColor
		{
			[Token(Token = "0x601DEB1")]
			[Address(RVA = "0x1771960", Offset = "0x1770560", VA = "0x181771960")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700463E RID: 17982
		// (get) Token: 0x0601DEB2 RID: 122546 RVA: 0x000ACDE8 File Offset: 0x000AAFE8
		[Token(Token = "0x1700463E")]
		public Color unavailableMarkColor
		{
			[Token(Token = "0x601DEB2")]
			[Address(RVA = "0x1771B40", Offset = "0x1770740", VA = "0x181771B40")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700463F RID: 17983
		// (get) Token: 0x0601DEB3 RID: 122547 RVA: 0x000ACE00 File Offset: 0x000AB000
		[Token(Token = "0x1700463F")]
		public Color filledUnavailableColor
		{
			[Token(Token = "0x601DEB3")]
			[Address(RVA = "0x17719E0", Offset = "0x17705E0", VA = "0x1817719E0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004640 RID: 17984
		// (get) Token: 0x0601DEB4 RID: 122548 RVA: 0x000ACE18 File Offset: 0x000AB018
		[Token(Token = "0x17004640")]
		public Color selectedOutlineColor
		{
			[Token(Token = "0x601DEB4")]
			[Address(RVA = "0x1771AC0", Offset = "0x17706C0", VA = "0x181771AC0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004641 RID: 17985
		// (get) Token: 0x0601DEB5 RID: 122549 RVA: 0x000ACE30 File Offset: 0x000AB030
		[Token(Token = "0x17004641")]
		public Color bkgFrontColor
		{
			[Token(Token = "0x601DEB5")]
			[Address(RVA = "0x1771790", Offset = "0x1770390", VA = "0x181771790")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004642 RID: 17986
		// (get) Token: 0x0601DEB6 RID: 122550 RVA: 0x000ACE48 File Offset: 0x000AB048
		[Token(Token = "0x17004642")]
		public float bkgShadowAlpha
		{
			[Token(Token = "0x601DEB6")]
			[Address(RVA = "0x1771900", Offset = "0x1770500", VA = "0x181771900")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004643 RID: 17987
		// (get) Token: 0x0601DEB7 RID: 122551 RVA: 0x000ACE60 File Offset: 0x000AB060
		[Token(Token = "0x17004643")]
		public Vector2 bkgOffset
		{
			[Token(Token = "0x601DEB7")]
			[Address(RVA = "0x1771810", Offset = "0x1770410", VA = "0x181771810")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0601DEB8 RID: 122552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEB8")]
		[Address(RVA = "0x1771710", Offset = "0x1770310", VA = "0x181771710")]
		public FireworkPlateViewStyle()
		{
		}

		// Token: 0x04027B5C RID: 162652
		[Token(Token = "0x4027B5C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _bkgOutlineColor;

		// Token: 0x04027B5D RID: 162653
		[Token(Token = "0x4027B5D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color[] _gridBkgColors;

		// Token: 0x04027B5E RID: 162654
		[Token(Token = "0x4027B5E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _centerMarkColor;

		// Token: 0x04027B5F RID: 162655
		[Token(Token = "0x4027B5F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _unavailableMarkColor;

		// Token: 0x04027B60 RID: 162656
		[Token(Token = "0x4027B60")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _filledUnavailableColor;

		// Token: 0x04027B61 RID: 162657
		[Token(Token = "0x4027B61")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _selectedOutlineColor;

		// Token: 0x04027B62 RID: 162658
		[Token(Token = "0x4027B62")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _bkgFrontColor;

		// Token: 0x04027B63 RID: 162659
		[Token(Token = "0x4027B63")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _bkgShadowAlpha;

		// Token: 0x04027B64 RID: 162660
		[Token(Token = "0x4027B64")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private Vector2 _bkgOffset;

		// Token: 0x04027B65 RID: 162661
		[Token(Token = "0x4027B65")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bkgOutlineColor;

		// Token: 0x04027B66 RID: 162662
		[Token(Token = "0x4027B66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_gridBkgColors;

		// Token: 0x04027B67 RID: 162663
		[Token(Token = "0x4027B67")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_centerMarkColor;

		// Token: 0x04027B68 RID: 162664
		[Token(Token = "0x4027B68")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_unavailableMarkColor;

		// Token: 0x04027B69 RID: 162665
		[Token(Token = "0x4027B69")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_filledUnavailableColor;

		// Token: 0x04027B6A RID: 162666
		[Token(Token = "0x4027B6A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selectedOutlineColor;

		// Token: 0x04027B6B RID: 162667
		[Token(Token = "0x4027B6B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bkgFrontColor;

		// Token: 0x04027B6C RID: 162668
		[Token(Token = "0x4027B6C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_bkgShadowAlpha;

		// Token: 0x04027B6D RID: 162669
		[Token(Token = "0x4027B6D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_bkgOffset;

		// Token: 0x04027B6E RID: 162670
		[Token(Token = "0x4027B6E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
