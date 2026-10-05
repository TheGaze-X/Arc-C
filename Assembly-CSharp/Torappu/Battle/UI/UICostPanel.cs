using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x02003376 RID: 13174
	[Token(Token = "0x2003376")]
	public class UICostPanel : MonoBehaviour
	{
		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x06015043 RID: 86083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031F0")]
		public Transform uiAnchor
		{
			[Token(Token = "0x6015043")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015044 RID: 86084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015044")]
		[Address(RVA = "0xD6ECF0", Offset = "0xD6D8F0", VA = "0x180D6ECF0")]
		public void OnInit(PlayerSide playerSide, bool listenEvent)
		{
		}

		// Token: 0x06015045 RID: 86085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015045")]
		[Address(RVA = "0xD6EF40", Offset = "0xD6DB40", VA = "0x180D6EF40")]
		public void UpdateData(BattleController controller)
		{
		}

		// Token: 0x06015046 RID: 86086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015046")]
		[Address(RVA = "0xD6F5E0", Offset = "0xD6E1E0", VA = "0x180D6F5E0")]
		private void _UpdateCost(int cost, bool force)
		{
		}

		// Token: 0x06015047 RID: 86087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015047")]
		[Address(RVA = "0xD6F290", Offset = "0xD6DE90", VA = "0x180D6F290")]
		private void _OnCostReached(object arg)
		{
		}

		// Token: 0x06015048 RID: 86088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015048")]
		[Address(RVA = "0xD6EF30", Offset = "0xD6DB30", VA = "0x180D6EF30")]
		public void OnPlayerSideChanged(PlayerSide newSide)
		{
		}

		// Token: 0x06015049 RID: 86089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015049")]
		[Address(RVA = "0xD6ECB0", Offset = "0xD6D8B0", VA = "0x180D6ECB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601504A RID: 86090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601504A")]
		[Address(RVA = "0xD6F690", Offset = "0xD6E290", VA = "0x180D6F690")]
		public UICostPanel()
		{
		}

		// Token: 0x0401901F RID: 102431
		[Token(Token = "0x401901F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _costLabel;

		// Token: 0x04019020 RID: 102432
		[Token(Token = "0x4019020")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _panelImage;

		// Token: 0x04019021 RID: 102433
		[Token(Token = "0x4019021")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _costSlider;

		// Token: 0x04019022 RID: 102434
		[Token(Token = "0x4019022")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _tweenTime;

		// Token: 0x04019023 RID: 102435
		[Token(Token = "0x4019023")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Color _tweenColor;

		// Token: 0x04019024 RID: 102436
		[Token(Token = "0x4019024")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Color _maxCostTweenColor;

		// Token: 0x04019025 RID: 102437
		[Token(Token = "0x4019025")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _maxCostIcon;

		// Token: 0x04019026 RID: 102438
		[Token(Token = "0x4019026")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _maxCostBar;

		// Token: 0x04019027 RID: 102439
		[Token(Token = "0x4019027")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _uiAnchor;

		// Token: 0x04019028 RID: 102440
		[Token(Token = "0x4019028")]
		[FieldOffset(Offset = "0x70")]
		private int m_cachedCost;

		// Token: 0x04019029 RID: 102441
		[Token(Token = "0x4019029")]
		[FieldOffset(Offset = "0x74")]
		private Color m_originColor;

		// Token: 0x0401902A RID: 102442
		[Token(Token = "0x401902A")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_tween;

		// Token: 0x0401902B RID: 102443
		[Token(Token = "0x401902B")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_maxCostIconTween;

		// Token: 0x0401902C RID: 102444
		[Token(Token = "0x401902C")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_maxCostBackgroundTween;

		// Token: 0x0401902D RID: 102445
		[Token(Token = "0x401902D")]
		[FieldOffset(Offset = "0xA0")]
		private PlayerSide m_playerSide;
	}
}
