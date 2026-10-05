using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B28 RID: 6952
	[Token(Token = "0x2001B28")]
	public class BuildingLaborDetailView : MonoBehaviour
	{
		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x0600AF07 RID: 44807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014BC")]
		protected Canvas rootCanvas
		{
			[Token(Token = "0x600AF07")]
			[Address(RVA = "0x3291B10", Offset = "0x3290710", VA = "0x183291B10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x0600AF08 RID: 44808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014BD")]
		protected AnimationSwitchTween switchTween
		{
			[Token(Token = "0x600AF08")]
			[Address(RVA = "0x3291C00", Offset = "0x3290800", VA = "0x183291C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AF09 RID: 44809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF09")]
		[Address(RVA = "0x3290D70", Offset = "0x328F970", VA = "0x183290D70")]
		public void RenderContent()
		{
		}

		// Token: 0x0600AF0A RID: 44810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF0A")]
		[Address(RVA = "0x32910B0", Offset = "0x328FCB0", VA = "0x1832910B0")]
		public void Show()
		{
		}

		// Token: 0x0600AF0B RID: 44811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF0B")]
		[Address(RVA = "0x32915D0", Offset = "0x32901D0", VA = "0x1832915D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600AF0C RID: 44812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF0C")]
		[Address(RVA = "0x3291110", Offset = "0x328FD10", VA = "0x183291110")]
		private void _AddBlankIfNeeded()
		{
		}

		// Token: 0x0600AF0D RID: 44813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF0D")]
		[Address(RVA = "0x32917A0", Offset = "0x32903A0", VA = "0x1832917A0")]
		private void _RemoveBlank()
		{
		}

		// Token: 0x0600AF0E RID: 44814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF0E")]
		[Address(RVA = "0x3291810", Offset = "0x3290410", VA = "0x183291810")]
		private void _RenderLabor()
		{
		}

		// Token: 0x0600AF0F RID: 44815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF0F")]
		[Address(RVA = "0x32910F0", Offset = "0x328FCF0", VA = "0x1832910F0")]
		private void Update()
		{
		}

		// Token: 0x0600AF10 RID: 44816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF10")]
		[Address(RVA = "0x3290BB0", Offset = "0x328F7B0", VA = "0x183290BB0")]
		public void EventOnBuyLaborClicked()
		{
		}

		// Token: 0x0600AF11 RID: 44817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF11")]
		[Address(RVA = "0x32916F0", Offset = "0x32902F0", VA = "0x1832916F0")]
		private void _OnBlankClicked()
		{
		}

		// Token: 0x0600AF12 RID: 44818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF12")]
		[Address(RVA = "0x3291790", Offset = "0x3290390", VA = "0x183291790")]
		private void _OnLaborTimeTick(BuildingLaborViewModel laborModel)
		{
		}

		// Token: 0x0600AF13 RID: 44819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF13")]
		[Address(RVA = "0x3291790", Offset = "0x3290390", VA = "0x183291790")]
		private void _OnLaborChange(BuildingLaborViewModel laborModel)
		{
		}

		// Token: 0x0600AF14 RID: 44820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF14")]
		[Address(RVA = "0x3291A90", Offset = "0x3290690", VA = "0x183291A90")]
		public BuildingLaborDetailView()
		{
		}

		// Token: 0x0400A859 RID: 43097
		[Token(Token = "0x400A859")]
		private const string EMPTY_TIME = "--:--:--";

		// Token: 0x0400A85A RID: 43098
		[Token(Token = "0x400A85A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FillProgressBar _progress;

		// Token: 0x0400A85B RID: 43099
		[Token(Token = "0x400A85B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTimeRemain;

		// Token: 0x0400A85C RID: 43100
		[Token(Token = "0x400A85C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textSpeedBuff;

		// Token: 0x0400A85D RID: 43101
		[Token(Token = "0x400A85D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockBuyLabor;

		// Token: 0x0400A85E RID: 43102
		[Token(Token = "0x400A85E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _arrowIcon;

		// Token: 0x0400A85F RID: 43103
		[Token(Token = "0x400A85F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0400A860 RID: 43104
		[Token(Token = "0x400A860")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _panelBlankContainer;

		// Token: 0x0400A861 RID: 43105
		[Token(Token = "0x400A861")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _blankPrefab;

		// Token: 0x0400A862 RID: 43106
		[Token(Token = "0x400A862")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorSpeedBuff;

		// Token: 0x0400A863 RID: 43107
		[Token(Token = "0x400A863")]
		[FieldOffset(Offset = "0x70")]
		private BuildingLaborViewModel m_laborModel;

		// Token: 0x0400A864 RID: 43108
		[Token(Token = "0x400A864")]
		[FieldOffset(Offset = "0x78")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0400A865 RID: 43109
		[Token(Token = "0x400A865")]
		[FieldOffset(Offset = "0x80")]
		private GameObject m_blankInst;

		// Token: 0x0400A866 RID: 43110
		[Token(Token = "0x400A866")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0400A867 RID: 43111
		[Token(Token = "0x400A867")]
		[FieldOffset(Offset = "0x90")]
		private Canvas m_rootCanvas;
	}
}
