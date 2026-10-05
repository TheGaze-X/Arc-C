using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FBA RID: 28602
	[Token(Token = "0x2006FBA")]
	public class ActMultiV3SquadEffectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005FD5 RID: 24533
		// (get) Token: 0x060289CA RID: 166346 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060289CB RID: 166347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FD5")]
		public Action<ActMultiV3SquadEffectModel, ActMultiV3SquadEffectItemView.Param> onClick
		{
			[Token(Token = "0x60289CA")]
			[Address(RVA = "0x23EFD00", Offset = "0x23EE900", VA = "0x1823EFD00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60289CB")]
			[Address(RVA = "0x23EFD60", Offset = "0x23EE960", VA = "0x1823EFD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060289CC RID: 166348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289CC")]
		[Address(RVA = "0x23EF150", Offset = "0x23EDD50", VA = "0x1823EF150")]
		public void Render(ActMultiV3SquadEffectModel effectModel, ActMultiV3SquadEffectSelectModel selectModel)
		{
		}

		// Token: 0x060289CD RID: 166349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289CD")]
		[Address(RVA = "0x23EF3F0", Offset = "0x23EDFF0", VA = "0x1823EF3F0")]
		public void Render(ActMultiV3SquadEffectModel effectModel, ActMultiV3SquadEffectItemView.Param param)
		{
		}

		// Token: 0x060289CE RID: 166350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289CE")]
		[Address(RVA = "0x23EF9B0", Offset = "0x23EE5B0", VA = "0x1823EF9B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060289CF RID: 166351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289CF")]
		[Address(RVA = "0x23EFB60", Offset = "0x23EE760", VA = "0x1823EFB60")]
		private void _RenderLockPart(ActMultiV3SquadEffectModel effectModel, ActMultiV3SquadEffectItemView.Param param)
		{
		}

		// Token: 0x060289D0 RID: 166352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289D0")]
		[Address(RVA = "0x23EF030", Offset = "0x23EDC30", VA = "0x1823EF030")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x060289D1 RID: 166353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289D1")]
		[Address(RVA = "0x23EFCA0", Offset = "0x23EE8A0", VA = "0x1823EFCA0")]
		public ActMultiV3SquadEffectItemView()
		{
		}

		// Token: 0x04039DAE RID: 236974
		[Token(Token = "0x4039DAE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectPartGO;

		// Token: 0x04039DAF RID: 236975
		[Token(Token = "0x4039DAF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyPartGO;

		// Token: 0x04039DB0 RID: 236976
		[Token(Token = "0x4039DB0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPartGO;

		// Token: 0x04039DB1 RID: 236977
		[Token(Token = "0x4039DB1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _equipPartGO;

		// Token: 0x04039DB2 RID: 236978
		[Token(Token = "0x4039DB2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _selfLabelPartGO;

		// Token: 0x04039DB3 RID: 236979
		[Token(Token = "0x4039DB3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _partnerLabelPartGO;

		// Token: 0x04039DB4 RID: 236980
		[Token(Token = "0x4039DB4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _lackKeyLockPartGO;

		// Token: 0x04039DB5 RID: 236981
		[Token(Token = "0x4039DB5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _unlockablePartGO;

		// Token: 0x04039DB6 RID: 236982
		[Token(Token = "0x4039DB6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04039DB7 RID: 236983
		[Token(Token = "0x4039DB7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgEffectIcon;

		// Token: 0x04039DB8 RID: 236984
		[Token(Token = "0x4039DB8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _imgThemeIcon;

		// Token: 0x04039DB9 RID: 236985
		[Token(Token = "0x4039DB9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _animUnlock;

		// Token: 0x04039DBA RID: 236986
		[Token(Token = "0x4039DBA")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04039DBB RID: 236987
		[Token(Token = "0x4039DBB")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039DBC RID: 236988
		[Token(Token = "0x4039DBC")]
		[FieldOffset(Offset = "0x98")]
		private string m_cacheThemeColor;

		// Token: 0x04039DBD RID: 236989
		[Token(Token = "0x4039DBD")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationSwitchTween m_unlockTween;

		// Token: 0x04039DBE RID: 236990
		[Token(Token = "0x4039DBE")]
		[FieldOffset(Offset = "0xA8")]
		private ActMultiV3SquadEffectModel m_effectModel;

		// Token: 0x04039DBF RID: 236991
		[Token(Token = "0x4039DBF")]
		[FieldOffset(Offset = "0xB0")]
		private ActMultiV3SquadEffectItemView.Param m_param;

		// Token: 0x04039DC1 RID: 236993
		[Token(Token = "0x4039DC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04039DC2 RID: 236994
		[Token(Token = "0x4039DC2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04039DC3 RID: 236995
		[Token(Token = "0x4039DC3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039DC4 RID: 236996
		[Token(Token = "0x4039DC4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x04039DC5 RID: 236997
		[Token(Token = "0x4039DC5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039DC6 RID: 236998
		[Token(Token = "0x4039DC6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderLockPart;

		// Token: 0x04039DC7 RID: 236999
		[Token(Token = "0x4039DC7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x04039DC8 RID: 237000
		[Token(Token = "0x4039DC8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FBB RID: 28603
		[Token(Token = "0x2006FBB")]
		public enum OverlayType
		{
			// Token: 0x04039DCA RID: 237002
			[Token(Token = "0x4039DCA")]
			NONE,
			// Token: 0x04039DCB RID: 237003
			[Token(Token = "0x4039DCB")]
			EQUIP,
			// Token: 0x04039DCC RID: 237004
			[Token(Token = "0x4039DCC")]
			SELF_LABEL,
			// Token: 0x04039DCD RID: 237005
			[Token(Token = "0x4039DCD")]
			PARTNER_LABEL
		}

		// Token: 0x02006FBC RID: 28604
		[Token(Token = "0x2006FBC")]
		public class Param
		{
			// Token: 0x060289D2 RID: 166354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60289D2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04039DCE RID: 237006
			[Token(Token = "0x4039DCE")]
			[FieldOffset(Offset = "0x10")]
			public bool isSelect;

			// Token: 0x04039DCF RID: 237007
			[Token(Token = "0x4039DCF")]
			[FieldOffset(Offset = "0x14")]
			public ActMultiV3SquadEffectItemView.OverlayType overlayType;

			// Token: 0x04039DD0 RID: 237008
			[Token(Token = "0x4039DD0")]
			[FieldOffset(Offset = "0x18")]
			public bool disableLockPart;

			// Token: 0x04039DD1 RID: 237009
			[Token(Token = "0x4039DD1")]
			[FieldOffset(Offset = "0x19")]
			public bool isKeyLack;

			// Token: 0x04039DD2 RID: 237010
			[Token(Token = "0x4039DD2")]
			[FieldOffset(Offset = "0x1C")]
			public int itemIdx;
		}
	}
}
