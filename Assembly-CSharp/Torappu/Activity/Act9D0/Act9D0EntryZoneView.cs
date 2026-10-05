using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007165 RID: 29029
	[Token(Token = "0x2007165")]
	public class Act9D0EntryZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006192 RID: 24978
		// (get) Token: 0x0602937C RID: 168828 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602937D RID: 168829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006192")]
		public Action<string> onZoneClicked
		{
			[Token(Token = "0x602937C")]
			[Address(RVA = "0x2495870", Offset = "0x2494470", VA = "0x182495870")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602937D")]
			[Address(RVA = "0x2495930", Offset = "0x2494530", VA = "0x182495930")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006193 RID: 24979
		// (get) Token: 0x0602937E RID: 168830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006193")]
		public string zoneId
		{
			[Token(Token = "0x602937E")]
			[Address(RVA = "0x24958D0", Offset = "0x24944D0", VA = "0x1824958D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602937F RID: 168831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602937F")]
		[Address(RVA = "0x24951D0", Offset = "0x2493DD0", VA = "0x1824951D0")]
		public void Render(Act9D0ZoneDescViewModel viewModel, bool isAllTimeout)
		{
		}

		// Token: 0x06029380 RID: 168832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029380")]
		[Address(RVA = "0x2495040", Offset = "0x2493C40", VA = "0x182495040")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06029381 RID: 168833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029381")]
		[Address(RVA = "0x2495810", Offset = "0x2494410", VA = "0x182495810")]
		public Act9D0EntryZoneView()
		{
		}

		// Token: 0x0403AD96 RID: 241046
		[Token(Token = "0x403AD96")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403AD97 RID: 241047
		[Token(Token = "0x403AD97")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0403AD98 RID: 241048
		[Token(Token = "0x403AD98")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textInfo;

		// Token: 0x0403AD99 RID: 241049
		[Token(Token = "0x403AD99")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x0403AD9A RID: 241050
		[Token(Token = "0x403AD9A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelAccessible;

		// Token: 0x0403AD9B RID: 241051
		[Token(Token = "0x403AD9B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelTimeout;

		// Token: 0x0403AD9C RID: 241052
		[Token(Token = "0x403AD9C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403AD9D RID: 241053
		[Token(Token = "0x403AD9D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _stagePushAudio;

		// Token: 0x0403AD9E RID: 241054
		[Token(Token = "0x403AD9E")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[Tooltip("A bad design. Don't use anymore.")]
		[Obsolete]
		[SerializeField]
		private UIStringEvent _onClicked;

		// Token: 0x0403ADA0 RID: 241056
		[Token(Token = "0x403ADA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onZoneClicked;

		// Token: 0x0403ADA1 RID: 241057
		[Token(Token = "0x403ADA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onZoneClicked;

		// Token: 0x0403ADA2 RID: 241058
		[Token(Token = "0x403ADA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0403ADA3 RID: 241059
		[Token(Token = "0x403ADA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403ADA4 RID: 241060
		[Token(Token = "0x403ADA4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403ADA5 RID: 241061
		[Token(Token = "0x403ADA5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
