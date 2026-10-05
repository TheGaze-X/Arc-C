using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077CA RID: 30666
	[Token(Token = "0x20077CA")]
	public class Act1VHalfIdleDirectGachaSelectTitleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B0AA RID: 176298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B0AA")]
		[Address(RVA = "0x26D98D0", Offset = "0x26D84D0", VA = "0x1826D98D0")]
		private Sprite _GetProfessionIconSprite(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x0602B0AB RID: 176299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0AB")]
		[Address(RVA = "0x26D9A40", Offset = "0x26D8640", VA = "0x1826D9A40")]
		private void _Render(Act1VHalfIdleDirectGachaSelectTitleItemView.VirtualView virtualView)
		{
		}

		// Token: 0x0602B0AC RID: 176300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0AC")]
		[Address(RVA = "0x26D9CB0", Offset = "0x26D88B0", VA = "0x1826D9CB0")]
		public Act1VHalfIdleDirectGachaSelectTitleItemView()
		{
		}

		// Token: 0x0403E290 RID: 254608
		[Token(Token = "0x403E290")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _height;

		// Token: 0x0403E291 RID: 254609
		[Token(Token = "0x403E291")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgProfessionIcon;

		// Token: 0x0403E292 RID: 254610
		[Token(Token = "0x403E292")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act1VHalfIdleDirectGachaSelectTitleItemView.ProfessionIconConfig[] _professionConfigs;

		// Token: 0x0403E293 RID: 254611
		[Token(Token = "0x403E293")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _professtionName;

		// Token: 0x0403E294 RID: 254612
		[Token(Token = "0x403E294")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _professionDesc;

		// Token: 0x0403E295 RID: 254613
		[Token(Token = "0x403E295")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetProfessionIconSprite;

		// Token: 0x0403E296 RID: 254614
		[Token(Token = "0x403E296")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403E297 RID: 254615
		[Token(Token = "0x403E297")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077CB RID: 30667
		[Token(Token = "0x20077CB")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<Act1VHalfIdleDirectGachaSelectTitleItemView>
		{
			// Token: 0x0602B0AD RID: 176301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0AD")]
			[Address(RVA = "0x26EDCF0", Offset = "0x26EC8F0", VA = "0x1826EDCF0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0602B0AE RID: 176302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0AE")]
			[Address(RVA = "0x26EDFF0", Offset = "0x26ECBF0", VA = "0x1826EDFF0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0602B0AF RID: 176303 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B0AF")]
			[Address(RVA = "0x26ED890", Offset = "0x26EC490", VA = "0x1826ED890", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0602B0B0 RID: 176304 RVA: 0x000DAAD8 File Offset: 0x000D8CD8
			[Token(Token = "0x602B0B0")]
			[Address(RVA = "0x26ED900", Offset = "0x26EC500", VA = "0x1826ED900", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0602B0B1 RID: 176305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0B1")]
			[Address(RVA = "0x26EE370", Offset = "0x26ECF70", VA = "0x1826EE370")]
			public VirtualView()
			{
			}

			// Token: 0x0403E298 RID: 254616
			[Token(Token = "0x403E298")]
			[FieldOffset(Offset = "0x20")]
			public ProfessionCategory profession;

			// Token: 0x0403E299 RID: 254617
			[Token(Token = "0x403E299")]
			[FieldOffset(Offset = "0x28")]
			public string professionDesc;

			// Token: 0x0403E29A RID: 254618
			[Token(Token = "0x403E29A")]
			[FieldOffset(Offset = "0x30")]
			public Act1VHalfIdleDirectGachaSelectTitleItemView prefab;

			// Token: 0x0403E29B RID: 254619
			[Token(Token = "0x403E29B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0403E29C RID: 254620
			[Token(Token = "0x403E29C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0403E29D RID: 254621
			[Token(Token = "0x403E29D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0403E29E RID: 254622
			[Token(Token = "0x403E29E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0403E29F RID: 254623
			[Token(Token = "0x403E29F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077CC RID: 30668
		[Token(Token = "0x20077CC")]
		[Serializable]
		private class ProfessionIconConfig : IHotfixable
		{
			// Token: 0x170064C9 RID: 25801
			// (get) Token: 0x0602B0B2 RID: 176306 RVA: 0x000DAAF0 File Offset: 0x000D8CF0
			[Token(Token = "0x170064C9")]
			public ProfessionCategory profession
			{
				[Token(Token = "0x602B0B2")]
				[Address(RVA = "0x26EC380", Offset = "0x26EAF80", VA = "0x1826EC380")]
				get
				{
					return ProfessionCategory.NONE;
				}
			}

			// Token: 0x170064CA RID: 25802
			// (get) Token: 0x0602B0B3 RID: 176307 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170064CA")]
			public Sprite professionIcon
			{
				[Token(Token = "0x602B0B3")]
				[Address(RVA = "0x26EC320", Offset = "0x26EAF20", VA = "0x1826EC320")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602B0B4 RID: 176308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0B4")]
			[Address(RVA = "0x26EC2C0", Offset = "0x26EAEC0", VA = "0x1826EC2C0")]
			public ProfessionIconConfig()
			{
			}

			// Token: 0x0403E2A0 RID: 254624
			[Token(Token = "0x403E2A0")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private ProfessionCategory _profession;

			// Token: 0x0403E2A1 RID: 254625
			[Token(Token = "0x403E2A1")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Sprite _professionIcon;

			// Token: 0x0403E2A2 RID: 254626
			[Token(Token = "0x403E2A2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_profession;

			// Token: 0x0403E2A3 RID: 254627
			[Token(Token = "0x403E2A3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_professionIcon;

			// Token: 0x0403E2A4 RID: 254628
			[Token(Token = "0x403E2A4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
