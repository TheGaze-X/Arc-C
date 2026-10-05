using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006139 RID: 24889
	[Token(Token = "0x2006139")]
	public class CampaignZoneMapJumpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023EF0 RID: 147184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EF0")]
		[Address(RVA = "0x1E94AD0", Offset = "0x1E936D0", VA = "0x181E94AD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023EF1 RID: 147185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EF1")]
		[Address(RVA = "0x1E94370", Offset = "0x1E92F70", VA = "0x181E94370")]
		public void RenderView(List<CampaignZoneJumpViewModel> viewModelList)
		{
		}

		// Token: 0x06023EF2 RID: 147186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EF2")]
		[Address(RVA = "0x1E94CC0", Offset = "0x1E938C0", VA = "0x181E94CC0")]
		public CampaignZoneMapJumpView()
		{
		}

		// Token: 0x04031E20 RID: 204320
		[Token(Token = "0x4031E20")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _rotateGameObject;

		// Token: 0x04031E21 RID: 204321
		[Token(Token = "0x4031E21")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _rotateContainer;

		// Token: 0x04031E22 RID: 204322
		[Token(Token = "0x4031E22")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _permContent;

		// Token: 0x04031E23 RID: 204323
		[Token(Token = "0x4031E23")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _trainContent;

		// Token: 0x04031E24 RID: 204324
		[Token(Token = "0x4031E24")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CampaignZoneMapJumpItem _jumpItem;

		// Token: 0x04031E25 RID: 204325
		[Token(Token = "0x4031E25")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CampaignZoneJumpEvent _jumpEvent;

		// Token: 0x04031E26 RID: 204326
		[Token(Token = "0x4031E26")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _rotateRemainText;

		// Token: 0x04031E27 RID: 204327
		[Token(Token = "0x4031E27")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _trainRemainText;

		// Token: 0x04031E28 RID: 204328
		[Token(Token = "0x4031E28")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _trainCommonPart;

		// Token: 0x04031E29 RID: 204329
		[Token(Token = "0x4031E29")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _trainAllOpenPart;

		// Token: 0x04031E2A RID: 204330
		[Token(Token = "0x4031E2A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _trainReturnAllOpenPart;

		// Token: 0x04031E2B RID: 204331
		[Token(Token = "0x4031E2B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _clockIcon;

		// Token: 0x04031E2C RID: 204332
		[Token(Token = "0x4031E2C")]
		[FieldOffset(Offset = "0x78")]
		private CampaignZoneMapJumpItem m_rotateJumpItem;

		// Token: 0x04031E2D RID: 204333
		[Token(Token = "0x4031E2D")]
		[FieldOffset(Offset = "0x80")]
		private CampaignZoneMapJumpView.Adapter m_permAdapter;

		// Token: 0x04031E2E RID: 204334
		[Token(Token = "0x4031E2E")]
		[FieldOffset(Offset = "0x88")]
		private CampaignZoneMapJumpView.Adapter m_trainAdapter;

		// Token: 0x04031E2F RID: 204335
		[Token(Token = "0x4031E2F")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04031E30 RID: 204336
		[Token(Token = "0x4031E30")]
		[NonSerialized]
		public const string GRAY_COLOR = "A0A0A0FF";

		// Token: 0x04031E31 RID: 204337
		[Token(Token = "0x4031E31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031E32 RID: 204338
		[Token(Token = "0x4031E32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04031E33 RID: 204339
		[Token(Token = "0x4031E33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200613A RID: 24890
		[Token(Token = "0x200613A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170054D5 RID: 21717
			// (get) Token: 0x06023EF3 RID: 147187 RVA: 0x000C26B8 File Offset: 0x000C08B8
			[Token(Token = "0x170054D5")]
			public override int count
			{
				[Token(Token = "0x6023EF3")]
				[Address(RVA = "0x1E83070", Offset = "0x1E81C70", VA = "0x181E83070", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023EF4 RID: 147188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023EF4")]
			[Address(RVA = "0x1E82D70", Offset = "0x1E81970", VA = "0x181E82D70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06023EF5 RID: 147189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023EF5")]
			[Address(RVA = "0x1E83010", Offset = "0x1E81C10", VA = "0x181E83010")]
			public Adapter()
			{
			}

			// Token: 0x04031E34 RID: 204340
			[Token(Token = "0x4031E34")]
			[FieldOffset(Offset = "0x20")]
			public CampaignZoneJumpEvent onClick;

			// Token: 0x04031E35 RID: 204341
			[Token(Token = "0x4031E35")]
			[FieldOffset(Offset = "0x28")]
			public List<CampaignZoneJumpViewModel> jumpViewModel;

			// Token: 0x04031E36 RID: 204342
			[Token(Token = "0x4031E36")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031E37 RID: 204343
			[Token(Token = "0x4031E37")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04031E38 RID: 204344
			[Token(Token = "0x4031E38")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
