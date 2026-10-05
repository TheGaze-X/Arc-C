using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A8D RID: 27277
	[Token(Token = "0x2006A8D")]
	public class StageMixStoryOverallGroupHeadComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027070 RID: 159856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027070")]
		[Address(RVA = "0x223FFA0", Offset = "0x223EBA0", VA = "0x18223FFA0")]
		private void _Render(StageMixStoryOverallGroupHeadComp.ViewModel model)
		{
		}

		// Token: 0x06027071 RID: 159857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027071")]
		[Address(RVA = "0x223FF10", Offset = "0x223EB10", VA = "0x18223FF10")]
		private void InitIfNot()
		{
		}

		// Token: 0x06027072 RID: 159858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027072")]
		[Address(RVA = "0x2240210", Offset = "0x223EE10", VA = "0x182240210")]
		public StageMixStoryOverallGroupHeadComp()
		{
		}

		// Token: 0x0403736E RID: 226158
		[Token(Token = "0x403736E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _storylinePanel;

		// Token: 0x0403736F RID: 226159
		[Token(Token = "0x403736F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _mainlinePanel;

		// Token: 0x04037370 RID: 226160
		[Token(Token = "0x4037370")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _otherPanel;

		// Token: 0x04037371 RID: 226161
		[Token(Token = "0x4037371")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIDynImage _storylineLogoImage;

		// Token: 0x04037372 RID: 226162
		[Token(Token = "0x4037372")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIDynImage _storylineAbbrImage;

		// Token: 0x04037373 RID: 226163
		[Token(Token = "0x4037373")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _storylineNameText;

		// Token: 0x04037374 RID: 226164
		[Token(Token = "0x4037374")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _releaseYearPanel;

		// Token: 0x04037375 RID: 226165
		[Token(Token = "0x4037375")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _releaseYearText;

		// Token: 0x04037376 RID: 226166
		[Token(Token = "0x4037376")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _height;

		// Token: 0x04037377 RID: 226167
		[Token(Token = "0x4037377")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_hasInited;

		// Token: 0x04037378 RID: 226168
		[Token(Token = "0x4037378")]
		[FieldOffset(Offset = "0x60")]
		private ILoadAsset m_iLoadAsset;

		// Token: 0x04037379 RID: 226169
		[Token(Token = "0x4037379")]
		[FieldOffset(Offset = "0x68")]
		private string m_loadedLogoId;

		// Token: 0x0403737A RID: 226170
		[Token(Token = "0x403737A")]
		[FieldOffset(Offset = "0x70")]
		private string m_loadedAbbrIconId;

		// Token: 0x0403737B RID: 226171
		[Token(Token = "0x403737B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403737C RID: 226172
		[Token(Token = "0x403737C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0403737D RID: 226173
		[Token(Token = "0x403737D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A8E RID: 27278
		[Token(Token = "0x2006A8E")]
		public class ViewModel
		{
			// Token: 0x06027073 RID: 159859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027073")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewModel()
			{
			}

			// Token: 0x0403737E RID: 226174
			[Token(Token = "0x403737E")]
			[FieldOffset(Offset = "0x10")]
			public StageMixStoryOverallGroupHeadComp prefab;

			// Token: 0x0403737F RID: 226175
			[Token(Token = "0x403737F")]
			[FieldOffset(Offset = "0x18")]
			public bool isReleaseYear;

			// Token: 0x04037380 RID: 226176
			[Token(Token = "0x4037380")]
			[FieldOffset(Offset = "0x19")]
			public bool isMainline;

			// Token: 0x04037381 RID: 226177
			[Token(Token = "0x4037381")]
			[FieldOffset(Offset = "0x20")]
			public string storylineLogoId;

			// Token: 0x04037382 RID: 226178
			[Token(Token = "0x4037382")]
			[FieldOffset(Offset = "0x28")]
			public string storylineIconId;

			// Token: 0x04037383 RID: 226179
			[Token(Token = "0x4037383")]
			[FieldOffset(Offset = "0x30")]
			public string storylineName;

			// Token: 0x04037384 RID: 226180
			[Token(Token = "0x4037384")]
			[FieldOffset(Offset = "0x38")]
			public int releaseYear;
		}

		// Token: 0x02006A8F RID: 27279
		[Token(Token = "0x2006A8F")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<StageMixStoryOverallGroupHeadComp>
		{
			// Token: 0x06027074 RID: 159860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027074")]
			[Address(RVA = "0x2249890", Offset = "0x2248490", VA = "0x182249890")]
			public VirtualView(StageMixStoryOverallGroupHeadComp.ViewModel model)
			{
			}

			// Token: 0x06027075 RID: 159861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027075")]
			[Address(RVA = "0x2249690", Offset = "0x2248290", VA = "0x182249690", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06027076 RID: 159862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027076")]
			[Address(RVA = "0x2249780", Offset = "0x2248380", VA = "0x182249780", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06027077 RID: 159863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027077")]
			[Address(RVA = "0x2249350", Offset = "0x2247F50", VA = "0x182249350", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06027078 RID: 159864 RVA: 0x000CD4E8 File Offset: 0x000CB6E8
			[Token(Token = "0x6027078")]
			[Address(RVA = "0x2249520", Offset = "0x2248120", VA = "0x182249520", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x04037385 RID: 226181
			[Token(Token = "0x4037385")]
			[FieldOffset(Offset = "0x20")]
			private readonly StageMixStoryOverallGroupHeadComp.ViewModel m_model;

			// Token: 0x04037386 RID: 226182
			[Token(Token = "0x4037386")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037387 RID: 226183
			[Token(Token = "0x4037387")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04037388 RID: 226184
			[Token(Token = "0x4037388")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04037389 RID: 226185
			[Token(Token = "0x4037389")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0403738A RID: 226186
			[Token(Token = "0x403738A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
