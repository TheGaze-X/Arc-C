using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003298 RID: 12952
	[Token(Token = "0x2003298")]
	public class Svash2S3CostHintPlugin : UIPluginTalent.UnitTalentUIPlugin, UICard.IUICardPlugin, IReusableObject, IReusable, IPtrObject
	{
		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x060148F2 RID: 84210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030A6")]
		protected new Character owner
		{
			[Token(Token = "0x60148F2")]
			[Address(RVA = "0xCD5750", Offset = "0xCD4350", VA = "0x180CD5750")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x060148F3 RID: 84211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030A7")]
		public string pluginId
		{
			[Token(Token = "0x60148F3")]
			[Address(RVA = "0xCD57B0", Offset = "0xCD43B0", VA = "0x180CD57B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x060148F4 RID: 84212 RVA: 0x00087720 File Offset: 0x00085920
		[Token(Token = "0x170030A8")]
		public UICard.UICardMountPoint mountPoint
		{
			[Token(Token = "0x60148F4")]
			[Address(RVA = "0xCD56F0", Offset = "0xCD42F0", VA = "0x180CD56F0", Slot = "13")]
			get
			{
				return UICard.UICardMountPoint.DEFAULT_PLUGIN_ROOT;
			}
		}

		// Token: 0x060148F5 RID: 84213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60148F5")]
		[Address(RVA = "0xCD4B00", Offset = "0xCD3700", VA = "0x180CD4B00", Slot = "18")]
		public MonoBehaviour GetRootMono()
		{
			return null;
		}

		// Token: 0x060148F6 RID: 84214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148F6")]
		[Address(RVA = "0xCD4930", Offset = "0xCD3530", VA = "0x180CD4930", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent talent)
		{
		}

		// Token: 0x060148F7 RID: 84215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148F7")]
		[Address(RVA = "0xCD4A90", Offset = "0xCD3690", VA = "0x180CD4A90", Slot = "10")]
		protected override void DoDetach()
		{
		}

		// Token: 0x060148F8 RID: 84216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148F8")]
		[Address(RVA = "0xCD4C70", Offset = "0xCD3870", VA = "0x180CD4C70", Slot = "15")]
		public void OnRender(UICard card)
		{
		}

		// Token: 0x060148F9 RID: 84217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148F9")]
		[Address(RVA = "0xCD4B60", Offset = "0xCD3760", VA = "0x180CD4B60", Slot = "14")]
		public void OnAppearanceRefresh(UICard card)
		{
		}

		// Token: 0x060148FA RID: 84218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148FA")]
		[Address(RVA = "0xCD4BE0", Offset = "0xCD37E0", VA = "0x180CD4BE0")]
		public void OnDestroy()
		{
		}

		// Token: 0x060148FB RID: 84219 RVA: 0x00087738 File Offset: 0x00085938
		[Token(Token = "0x60148FB")]
		[Address(RVA = "0xCD5460", Offset = "0xCD4060", VA = "0x180CD5460")]
		private bool _NeedPlay(UICard card)
		{
			return default(bool);
		}

		// Token: 0x060148FC RID: 84220 RVA: 0x00087750 File Offset: 0x00085950
		[Token(Token = "0x60148FC")]
		[Address(RVA = "0xCD5390", Offset = "0xCD3F90", VA = "0x180CD5390")]
		private bool _NeedPlayFromStart(UICard card)
		{
			return default(bool);
		}

		// Token: 0x060148FD RID: 84221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148FD")]
		[Address(RVA = "0xCD5040", Offset = "0xCD3C40", VA = "0x180CD5040")]
		private void _DoPlayAnimation(bool clipAtStart)
		{
		}

		// Token: 0x060148FE RID: 84222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148FE")]
		[Address(RVA = "0xCD5280", Offset = "0xCD3E80", VA = "0x180CD5280")]
		private void _DoStopAnimation()
		{
		}

		// Token: 0x060148FF RID: 84223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148FF")]
		[Address(RVA = "0xCD5660", Offset = "0xCD4260", VA = "0x180CD5660")]
		public Svash2S3CostHintPlugin()
		{
		}

		// Token: 0x06014900 RID: 84224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014900")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x06014901 RID: 84225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014901")]
		[Address(RVA = "0xCCC680", Offset = "0xCCB280", VA = "0x180CCC680")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04018523 RID: 99619
		[Token(Token = "0x4018523")]
		private const string PLUGIN_ID = "Svash2S3CostHintPlugin";

		// Token: 0x04018524 RID: 99620
		[Token(Token = "0x4018524")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _root;

		// Token: 0x04018525 RID: 99621
		[Token(Token = "0x4018525")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICard.UICardMountPoint _mountPoint;

		// Token: 0x04018526 RID: 99622
		[Token(Token = "0x4018526")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _defaultTransData;

		// Token: 0x04018527 RID: 99623
		[Token(Token = "0x4018527")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _location;

		// Token: 0x04018528 RID: 99624
		[Token(Token = "0x4018528")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _audioSignalOnPlay;

		// Token: 0x04018529 RID: 99625
		[Token(Token = "0x4018529")]
		[FieldOffset(Offset = "0x60")]
		private UICard m_cardAttached;

		// Token: 0x0401852A RID: 99626
		[Token(Token = "0x401852A")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_tween;

		// Token: 0x0401852B RID: 99627
		[Token(Token = "0x401852B")]
		[FieldOffset(Offset = "0x70")]
		private Character m_character;

		// Token: 0x0401852C RID: 99628
		[Token(Token = "0x401852C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x0401852D RID: 99629
		[Token(Token = "0x401852D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pluginId;

		// Token: 0x0401852E RID: 99630
		[Token(Token = "0x401852E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_mountPoint;

		// Token: 0x0401852F RID: 99631
		[Token(Token = "0x401852F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetRootMono;

		// Token: 0x04018530 RID: 99632
		[Token(Token = "0x4018530")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04018531 RID: 99633
		[Token(Token = "0x4018531")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04018532 RID: 99634
		[Token(Token = "0x4018532")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04018533 RID: 99635
		[Token(Token = "0x4018533")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnAppearanceRefresh;

		// Token: 0x04018534 RID: 99636
		[Token(Token = "0x4018534")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04018535 RID: 99637
		[Token(Token = "0x4018535")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__NeedPlay;

		// Token: 0x04018536 RID: 99638
		[Token(Token = "0x4018536")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__NeedPlayFromStart;

		// Token: 0x04018537 RID: 99639
		[Token(Token = "0x4018537")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoPlayAnimation;

		// Token: 0x04018538 RID: 99640
		[Token(Token = "0x4018538")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DoStopAnimation;

		// Token: 0x04018539 RID: 99641
		[Token(Token = "0x4018539")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
