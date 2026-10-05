using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A8B RID: 6795
	[Token(Token = "0x2001A8B")]
	public abstract class VCharFavorIcon : VOUIPanel
	{
		// Token: 0x0600AB4E RID: 43854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB4E")]
		[Address(RVA = "0x32560C0", Offset = "0x3254CC0", VA = "0x1832560C0")]
		public VCharFavorIcon()
		{
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x0600AB4F RID: 43855 RVA: 0x00042420 File Offset: 0x00040620
		[Token(Token = "0x1700143A")]
		protected BuildingCharModel charModel
		{
			[Token(Token = "0x600AB4F")]
			[Address(RVA = "0x22F8700", Offset = "0x22F7300", VA = "0x1822F8700")]
			get
			{
				return default(BuildingCharModel);
			}
		}

		// Token: 0x0600AB50 RID: 43856 RVA: 0x00042438 File Offset: 0x00040638
		[Token(Token = "0x600AB50")]
		[Address(RVA = "0x32554A0", Offset = "0x32540A0", VA = "0x1832554A0", Slot = "5")]
		protected override Vector3 PanelWorldCenter()
		{
			return default(Vector3);
		}

		// Token: 0x0600AB51 RID: 43857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB51")]
		[Address(RVA = "0x3255000", Offset = "0x3253C00", VA = "0x183255000", Slot = "6")]
		protected override void OnRoomObjectBinded(VRoom.Object roomObj)
		{
		}

		// Token: 0x0600AB52 RID: 43858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB52")]
		[Address(RVA = "0x32553B0", Offset = "0x3253FB0", VA = "0x1832553B0", Slot = "8")]
		protected override void OnRoomObjectUnbinded(VRoom.Object oldRoomObj)
		{
		}

		// Token: 0x0600AB53 RID: 43859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB53")]
		[Address(RVA = "0x3255620", Offset = "0x3254220", VA = "0x183255620", Slot = "9")]
		protected override void UpdateRender()
		{
		}

		// Token: 0x0600AB54 RID: 43860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB54")]
		[Address(RVA = "0x32551D0", Offset = "0x3253DD0", VA = "0x1832551D0", Slot = "7")]
		protected override void OnRoomObjectStatusChanged()
		{
		}

		// Token: 0x0600AB55 RID: 43861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB55")]
		[Address(RVA = "0x3254F60", Offset = "0x3253B60", VA = "0x183254F60")]
		public void OnClick()
		{
		}

		// Token: 0x0600AB56 RID: 43862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB56")]
		[Address(RVA = "0x3255F80", Offset = "0x3254B80", VA = "0x183255F80")]
		private void _TryToRenderInitIfNot(bool isVisible)
		{
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x00042450 File Offset: 0x00040650
		[Token(Token = "0x600AB57")]
		[Address(RVA = "0x3255B00", Offset = "0x3254700", VA = "0x183255B00")]
		private bool _OnInteract(VCharacter character)
		{
			return default(bool);
		}

		// Token: 0x0600AB58 RID: 43864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB58")]
		[Address(RVA = "0x3255810", Offset = "0x3254410", VA = "0x183255810")]
		private void _OnIncIntimacySucceeded()
		{
		}

		// Token: 0x0600AB59 RID: 43865 RVA: 0x00042468 File Offset: 0x00040668
		[Token(Token = "0x600AB59")]
		[Address(RVA = "0x32557E0", Offset = "0x32543E0", VA = "0x1832557E0")]
		private bool _OnIncIntimacyFailed()
		{
			return default(bool);
		}

		// Token: 0x0600AB5A RID: 43866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB5A")]
		[Address(RVA = "0x32557F0", Offset = "0x32543F0", VA = "0x1832557F0")]
		private void _OnIncIntimacyFinal()
		{
		}

		// Token: 0x0600AB5B RID: 43867
		[Token(Token = "0x600AB5B")]
		protected abstract void SendIncIntimacyService(Action onSucceed, Func<bool> onFail, Action onFinal);

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700143B")]
		private ILODHolder lodHolder
		{
			[Token(Token = "0x600AB5C")]
			[Address(RVA = "0x3256210", Offset = "0x3254E10", VA = "0x183256210")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x0600AB5D RID: 43869 RVA: 0x00042480 File Offset: 0x00040680
		[Token(Token = "0x1700143C")]
		private bool lodVisible
		{
			[Token(Token = "0x600AB5D")]
			[Address(RVA = "0x3256270", Offset = "0x3254E70", VA = "0x183256270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600AB5E RID: 43870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB5E")]
		[Address(RVA = "0x3255DF0", Offset = "0x32549F0", VA = "0x183255DF0")]
		private void _SendFavorService()
		{
		}

		// Token: 0x0600AB5F RID: 43871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB5F")]
		[Address(RVA = "0x3255FD0", Offset = "0x3254BD0", VA = "0x183255FD0")]
		private void _UpdateFavorPercent(int favorPoint)
		{
		}

		// Token: 0x0400A394 RID: 41876
		[Token(Token = "0x400A394")]
		private const float VIS_TWEEN_DUR = 0.23f;

		// Token: 0x0400A395 RID: 41877
		[Token(Token = "0x400A395")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _favorIcon;

		// Token: 0x0400A396 RID: 41878
		[Token(Token = "0x400A396")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _progressImage;

		// Token: 0x0400A397 RID: 41879
		[Token(Token = "0x400A397")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _addFavorPointText;

		// Token: 0x0400A398 RID: 41880
		[Token(Token = "0x400A398")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _fullState;

		// Token: 0x0400A399 RID: 41881
		[Token(Token = "0x400A399")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _notFullState;

		// Token: 0x0400A39A RID: 41882
		[Token(Token = "0x400A39A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0400A39B RID: 41883
		[Token(Token = "0x400A39B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _circleRippleAnim;

		// Token: 0x0400A39C RID: 41884
		[Token(Token = "0x400A39C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _releaseAnim;

		// Token: 0x0400A39D RID: 41885
		[Token(Token = "0x400A39D")]
		[FieldOffset(Offset = "0x78")]
		private VCharacter.IListener m_charListener;

		// Token: 0x0400A39E RID: 41886
		[Token(Token = "0x400A39E")]
		[FieldOffset(Offset = "0x80")]
		private VCharFavorIcon.InteractState m_interState;

		// Token: 0x0400A39F RID: 41887
		[Token(Token = "0x400A39F")]
		[FieldOffset(Offset = "0x88")]
		private BuildingCharModel m_charModel;

		// Token: 0x0400A3A0 RID: 41888
		[Token(Token = "0x400A3A0")]
		[FieldOffset(Offset = "0x100")]
		private int m_curFavorPercent;

		// Token: 0x0400A3A1 RID: 41889
		[Token(Token = "0x400A3A1")]
		[FieldOffset(Offset = "0x104")]
		private bool m_isVisible;

		// Token: 0x0400A3A2 RID: 41890
		[Token(Token = "0x400A3A2")]
		[FieldOffset(Offset = "0x105")]
		private bool m_isRenderInited;

		// Token: 0x0400A3A3 RID: 41891
		[Token(Token = "0x400A3A3")]
		[FieldOffset(Offset = "0x108")]
		private Tween m_cachedTween;

		// Token: 0x0400A3A4 RID: 41892
		[Token(Token = "0x400A3A4")]
		[FieldOffset(Offset = "0x110")]
		public VCharacter m_cacheChar;

		// Token: 0x0400A3A5 RID: 41893
		[Token(Token = "0x400A3A5")]
		[FieldOffset(Offset = "0x118")]
		private ILODHolder m_lodHolder;

		// Token: 0x02001A8C RID: 6796
		[Token(Token = "0x2001A8C")]
		private enum InteractState
		{
			// Token: 0x0400A3A7 RID: 41895
			[Token(Token = "0x400A3A7")]
			NONE,
			// Token: 0x0400A3A8 RID: 41896
			[Token(Token = "0x400A3A8")]
			NORMAL,
			// Token: 0x0400A3A9 RID: 41897
			[Token(Token = "0x400A3A9")]
			SERVICE,
			// Token: 0x0400A3AA RID: 41898
			[Token(Token = "0x400A3AA")]
			DISAPPEARING,
			// Token: 0x0400A3AB RID: 41899
			[Token(Token = "0x400A3AB")]
			HIDE
		}

		// Token: 0x02001A8D RID: 6797
		[Token(Token = "0x2001A8D")]
		private class CharListener : VCharacter.IListener
		{
			// Token: 0x0600AB62 RID: 43874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB62")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public CharListener(VCharFavorIcon closure)
			{
			}

			// Token: 0x0600AB63 RID: 43875 RVA: 0x00042498 File Offset: 0x00040698
			[Token(Token = "0x600AB63")]
			[Address(RVA = "0x3251630", Offset = "0x3250230", VA = "0x183251630", Slot = "4")]
			public bool OnInteract(VCharacter character)
			{
				return default(bool);
			}

			// Token: 0x0600AB64 RID: 43876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB64")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public void OnSleepChanged(bool isSleep)
			{
			}

			// Token: 0x0400A3AC RID: 41900
			[Token(Token = "0x400A3AC")]
			[FieldOffset(Offset = "0x10")]
			private VCharFavorIcon m_closure;
		}
	}
}
