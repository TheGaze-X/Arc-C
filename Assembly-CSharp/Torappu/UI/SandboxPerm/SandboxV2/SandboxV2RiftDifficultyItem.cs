using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200438A RID: 17290
	[Token(Token = "0x200438A")]
	public class SandboxV2RiftDifficultyItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A8CE RID: 108750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8CE")]
		[Address(RVA = "0x13B06F0", Offset = "0x13AF2F0", VA = "0x1813B06F0")]
		public void Render(SandboxV2RiftDifficultyItem.Param param, float selectIndex)
		{
		}

		// Token: 0x0601A8CF RID: 108751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8CF")]
		[Address(RVA = "0x13B0960", Offset = "0x13AF560", VA = "0x1813B0960")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A8D0 RID: 108752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8D0")]
		[Address(RVA = "0x13B0670", Offset = "0x13AF270", VA = "0x1813B0670")]
		public void OnDifficultyItemClicked()
		{
		}

		// Token: 0x0601A8D1 RID: 108753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8D1")]
		[Address(RVA = "0x13B09E0", Offset = "0x13AF5E0", VA = "0x1813B09E0")]
		public SandboxV2RiftDifficultyItem()
		{
		}

		// Token: 0x04021CAF RID: 138415
		[Token(Token = "0x4021CAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _difficultyLevel;

		// Token: 0x04021CB0 RID: 138416
		[Token(Token = "0x4021CB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _bgToggle;

		// Token: 0x04021CB1 RID: 138417
		[Token(Token = "0x4021CB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _completedGo;

		// Token: 0x04021CB2 RID: 138418
		[Token(Token = "0x4021CB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _newTrackGo;

		// Token: 0x04021CB3 RID: 138419
		[Token(Token = "0x4021CB3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockIconGo;

		// Token: 0x04021CB4 RID: 138420
		[Token(Token = "0x4021CB4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _sizeAnim;

		// Token: 0x04021CB5 RID: 138421
		[Token(Token = "0x4021CB5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _canSelectLevelColor;

		// Token: 0x04021CB6 RID: 138422
		[Token(Token = "0x4021CB6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _canNotSelectLevelColor;

		// Token: 0x04021CB7 RID: 138423
		[Token(Token = "0x4021CB7")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x04021CB8 RID: 138424
		[Token(Token = "0x4021CB8")]
		[FieldOffset(Offset = "0x78")]
		private Action<int> m_onClicked;

		// Token: 0x04021CB9 RID: 138425
		[Token(Token = "0x4021CB9")]
		[FieldOffset(Offset = "0x80")]
		private int m_difficultyLevel;

		// Token: 0x04021CBA RID: 138426
		[Token(Token = "0x4021CBA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021CBB RID: 138427
		[Token(Token = "0x4021CBB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021CBC RID: 138428
		[Token(Token = "0x4021CBC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDifficultyItemClicked;

		// Token: 0x04021CBD RID: 138429
		[Token(Token = "0x4021CBD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200438B RID: 17291
		[Token(Token = "0x200438B")]
		public class Param : IHotfixable
		{
			// Token: 0x0601A8D2 RID: 108754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8D2")]
			[Address(RVA = "0x13A7500", Offset = "0x13A6100", VA = "0x1813A7500")]
			public Param()
			{
			}

			// Token: 0x04021CBE RID: 138430
			[Token(Token = "0x4021CBE")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2RiftDifficultyItem prefab;

			// Token: 0x04021CBF RID: 138431
			[Token(Token = "0x4021CBF")]
			[FieldOffset(Offset = "0x18")]
			public int difficultyLevel;

			// Token: 0x04021CC0 RID: 138432
			[Token(Token = "0x4021CC0")]
			[FieldOffset(Offset = "0x1C")]
			public int selectableLevel;

			// Token: 0x04021CC1 RID: 138433
			[Token(Token = "0x4021CC1")]
			[FieldOffset(Offset = "0x20")]
			public int pageIndex;

			// Token: 0x04021CC2 RID: 138434
			[Token(Token = "0x4021CC2")]
			[FieldOffset(Offset = "0x24")]
			public bool hasCompleted;

			// Token: 0x04021CC3 RID: 138435
			[Token(Token = "0x4021CC3")]
			[FieldOffset(Offset = "0x25")]
			public bool hasNewTrack;

			// Token: 0x04021CC4 RID: 138436
			[Token(Token = "0x4021CC4")]
			[FieldOffset(Offset = "0x28")]
			public float preferredWidthMin;

			// Token: 0x04021CC5 RID: 138437
			[Token(Token = "0x4021CC5")]
			[FieldOffset(Offset = "0x2C")]
			public float preferredWidthMax;

			// Token: 0x04021CC6 RID: 138438
			[Token(Token = "0x4021CC6")]
			[FieldOffset(Offset = "0x30")]
			public Action<int> onClicked;

			// Token: 0x04021CC7 RID: 138439
			[Token(Token = "0x4021CC7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200438C RID: 17292
		[Token(Token = "0x200438C")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<SandboxV2RiftDifficultyItem>
		{
			// Token: 0x0601A8D3 RID: 108755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8D3")]
			[Address(RVA = "0x13BCB70", Offset = "0x13BB770", VA = "0x1813BCB70")]
			public VirtualView(SandboxV2RiftDifficultyItem.Param param)
			{
			}

			// Token: 0x0601A8D4 RID: 108756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8D4")]
			[Address(RVA = "0x13BCA70", Offset = "0x13BB670", VA = "0x1813BCA70")]
			public void UpdateFocusPage(float focus)
			{
			}

			// Token: 0x0601A8D5 RID: 108757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A8D5")]
			[Address(RVA = "0x13BC840", Offset = "0x13BB440", VA = "0x1813BC840", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601A8D6 RID: 108758 RVA: 0x000A2570 File Offset: 0x000A0770
			[Token(Token = "0x601A8D6")]
			[Address(RVA = "0x13BC8B0", Offset = "0x13BB4B0", VA = "0x1813BC8B0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601A8D7 RID: 108759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8D7")]
			[Address(RVA = "0x13BC980", Offset = "0x13BB580", VA = "0x1813BC980", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601A8D8 RID: 108760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8D8")]
			[Address(RVA = "0x13BCA10", Offset = "0x13BB610", VA = "0x1813BCA10", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x04021CC8 RID: 138440
			[Token(Token = "0x4021CC8")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RiftDifficultyItem.Param m_param;

			// Token: 0x04021CC9 RID: 138441
			[Token(Token = "0x4021CC9")]
			[FieldOffset(Offset = "0x28")]
			private float m_focusPageIndex;

			// Token: 0x04021CCA RID: 138442
			[Token(Token = "0x4021CCA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021CCB RID: 138443
			[Token(Token = "0x4021CCB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateFocusPage;

			// Token: 0x04021CCC RID: 138444
			[Token(Token = "0x4021CCC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04021CCD RID: 138445
			[Token(Token = "0x4021CCD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x04021CCE RID: 138446
			[Token(Token = "0x4021CCE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04021CCF RID: 138447
			[Token(Token = "0x4021CCF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnViewDetached;
		}
	}
}
