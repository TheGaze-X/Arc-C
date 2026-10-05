using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003299 RID: 12953
	[Token(Token = "0x2003299")]
	public class Svash2TokenDeployPlugin : UIPluginTalent.UnitTalentUIPlugin, UICard.IUICardPlugin, IReusableObject, IReusable, IPtrObject
	{
		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x06014902 RID: 84226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030A9")]
		public string pluginId
		{
			[Token(Token = "0x6014902")]
			[Address(RVA = "0xCD61E0", Offset = "0xCD4DE0", VA = "0x180CD61E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014903 RID: 84227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014903")]
		[Address(RVA = "0xCD59F0", Offset = "0xCD45F0", VA = "0x180CD59F0", Slot = "18")]
		public MonoBehaviour GetRootMono()
		{
			return null;
		}

		// Token: 0x06014904 RID: 84228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014904")]
		[Address(RVA = "0xCD5820", Offset = "0xCD4420", VA = "0x180CD5820", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent talent)
		{
		}

		// Token: 0x06014905 RID: 84229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014905")]
		[Address(RVA = "0xCD5980", Offset = "0xCD4580", VA = "0x180CD5980", Slot = "10")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06014906 RID: 84230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014906")]
		[Address(RVA = "0xCD5B40", Offset = "0xCD4740", VA = "0x180CD5B40", Slot = "15")]
		public void OnRender(UICard card)
		{
		}

		// Token: 0x06014907 RID: 84231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014907")]
		[Address(RVA = "0xCD5AE0", Offset = "0xCD46E0", VA = "0x180CD5AE0", Slot = "16")]
		public void OnInit(UICard uiCard)
		{
		}

		// Token: 0x06014908 RID: 84232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014908")]
		[Address(RVA = "0xCD5EE0", Offset = "0xCD4AE0", VA = "0x180CD5EE0")]
		private void _DoPlayAnimation(UIAnimationLocation location, bool isSameCard)
		{
		}

		// Token: 0x06014909 RID: 84233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014909")]
		[Address(RVA = "0xCD6060", Offset = "0xCD4C60", VA = "0x180CD6060")]
		private void _DoStopAnimation(UIAnimationLocation location)
		{
		}

		// Token: 0x0601490A RID: 84234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601490A")]
		[Address(RVA = "0xCD5A50", Offset = "0xCD4650", VA = "0x180CD5A50")]
		protected void OnDestroy()
		{
		}

		// Token: 0x0601490B RID: 84235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601490B")]
		[Address(RVA = "0xCD6180", Offset = "0xCD4D80", VA = "0x180CD6180")]
		public Svash2TokenDeployPlugin()
		{
		}

		// Token: 0x0601490C RID: 84236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601490C")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x0601490D RID: 84237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601490D")]
		[Address(RVA = "0xCCC680", Offset = "0xCCB280", VA = "0x180CCC680")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0401853A RID: 99642
		[Token(Token = "0x401853A")]
		private const string PLUGIN_FORMAT_PARTTERN = "Svash2TokenDeployPlugin_{0}";

		// Token: 0x0401853B RID: 99643
		[Token(Token = "0x401853B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _root;

		// Token: 0x0401853C RID: 99644
		[Token(Token = "0x401853C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _canBuildAnimation;

		// Token: 0x0401853D RID: 99645
		[Token(Token = "0x401853D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _cannotBuildAnimation;

		// Token: 0x0401853E RID: 99646
		[Token(Token = "0x401853E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _defaultTransData;

		// Token: 0x0401853F RID: 99647
		[Token(Token = "0x401853F")]
		[FieldOffset(Offset = "0x60")]
		private string m_pluginId;

		// Token: 0x04018540 RID: 99648
		[Token(Token = "0x4018540")]
		[FieldOffset(Offset = "0x68")]
		private uint m_validUid;

		// Token: 0x04018541 RID: 99649
		[Token(Token = "0x4018541")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_curUid;

		// Token: 0x04018542 RID: 99650
		[Token(Token = "0x4018542")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isDisplayedAsCanBuild;

		// Token: 0x04018543 RID: 99651
		[Token(Token = "0x4018543")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_playingTween;

		// Token: 0x04018544 RID: 99652
		[Token(Token = "0x4018544")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pluginId;

		// Token: 0x04018545 RID: 99653
		[Token(Token = "0x4018545")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRootMono;

		// Token: 0x04018546 RID: 99654
		[Token(Token = "0x4018546")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04018547 RID: 99655
		[Token(Token = "0x4018547")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04018548 RID: 99656
		[Token(Token = "0x4018548")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04018549 RID: 99657
		[Token(Token = "0x4018549")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401854A RID: 99658
		[Token(Token = "0x401854A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoPlayAnimation;

		// Token: 0x0401854B RID: 99659
		[Token(Token = "0x401854B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoStopAnimation;

		// Token: 0x0401854C RID: 99660
		[Token(Token = "0x401854C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401854D RID: 99661
		[Token(Token = "0x401854D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
