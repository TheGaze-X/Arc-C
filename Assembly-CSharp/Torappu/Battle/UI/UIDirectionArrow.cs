using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x02003378 RID: 13176
	[Token(Token = "0x2003378")]
	[RequireComponent(typeof(Image))]
	public class UIDirectionArrow : MonoBehaviour
	{
		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0601504E RID: 86094 RVA: 0x0008A1B0 File Offset: 0x000883B0
		// (set) Token: 0x0601504F RID: 86095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031F2")]
		public bool isHover
		{
			[Token(Token = "0x601504E")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601504F")]
			[Address(RVA = "0xD6FC80", Offset = "0xD6E880", VA = "0x180D6FC80")]
			set
			{
			}
		}

		// Token: 0x06015050 RID: 86096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015050")]
		[Address(RVA = "0xD6FB40", Offset = "0xD6E740", VA = "0x180D6FB40")]
		public void SetData(SharedConsts.Direction direction, UIDirectionSelector selector)
		{
		}

		// Token: 0x06015051 RID: 86097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015051")]
		[Address(RVA = "0xD6FAF0", Offset = "0xD6E6F0", VA = "0x180D6FAF0")]
		private void Awake()
		{
		}

		// Token: 0x06015052 RID: 86098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015052")]
		[Address(RVA = "0xD6FC60", Offset = "0xD6E860", VA = "0x180D6FC60")]
		public UIDirectionArrow()
		{
		}

		// Token: 0x04019035 RID: 102453
		[Token(Token = "0x4019035")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _normalColor;

		// Token: 0x04019036 RID: 102454
		[Token(Token = "0x4019036")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _highlightColor;

		// Token: 0x04019037 RID: 102455
		[Token(Token = "0x4019037")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _fillBack;

		// Token: 0x04019038 RID: 102456
		[Token(Token = "0x4019038")]
		[FieldOffset(Offset = "0x40")]
		private Image m_image;

		// Token: 0x04019039 RID: 102457
		[Token(Token = "0x4019039")]
		[FieldOffset(Offset = "0x48")]
		private SharedConsts.Direction m_direction;

		// Token: 0x0401903A RID: 102458
		[Token(Token = "0x401903A")]
		[FieldOffset(Offset = "0x50")]
		private UIDirectionSelector m_selector;

		// Token: 0x0401903B RID: 102459
		[Token(Token = "0x401903B")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isHover;
	}
}
