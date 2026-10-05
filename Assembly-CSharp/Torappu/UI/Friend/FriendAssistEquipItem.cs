using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D98 RID: 19864
	[Token(Token = "0x2004D98")]
	public class FriendAssistEquipItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DB81 RID: 121729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB81")]
		[Address(RVA = "0x173C0B0", Offset = "0x173ACB0", VA = "0x18173C0B0")]
		private void _InitIfNot(float parentScale)
		{
		}

		// Token: 0x0601DB82 RID: 121730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB82")]
		[Address(RVA = "0x173BC30", Offset = "0x173A830", VA = "0x18173BC30")]
		public void Render(string equipId, string charId, FriendAssistEquipItem.RenderOptions options)
		{
		}

		// Token: 0x0601DB83 RID: 121731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB83")]
		[Address(RVA = "0x173BBB0", Offset = "0x173A7B0", VA = "0x18173BBB0")]
		public void OnClick()
		{
		}

		// Token: 0x0601DB84 RID: 121732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB84")]
		[Address(RVA = "0x173C270", Offset = "0x173AE70", VA = "0x18173C270")]
		public FriendAssistEquipItem()
		{
		}

		// Token: 0x0402747A RID: 160890
		[Token(Token = "0x402747A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICommonEquipTypeIcon _equipIconPrefab;

		// Token: 0x0402747B RID: 160891
		[Token(Token = "0x402747B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _equipIconContainer;

		// Token: 0x0402747C RID: 160892
		[Token(Token = "0x402747C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _equipIconScale;

		// Token: 0x0402747D RID: 160893
		[Token(Token = "0x402747D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _unselectAlpha;

		// Token: 0x0402747E RID: 160894
		[Token(Token = "0x402747E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _pressButton;

		// Token: 0x0402747F RID: 160895
		[Token(Token = "0x402747F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _iconPanel;

		// Token: 0x04027480 RID: 160896
		[Token(Token = "0x4027480")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _slectedPanel;

		// Token: 0x04027481 RID: 160897
		[Token(Token = "0x4027481")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _noneEquipPanel;

		// Token: 0x04027482 RID: 160898
		[Token(Token = "0x4027482")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _lockEquipPanel;

		// Token: 0x04027483 RID: 160899
		[Token(Token = "0x4027483")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x04027484 RID: 160900
		[Token(Token = "0x4027484")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelText;

		// Token: 0x04027485 RID: 160901
		[Token(Token = "0x4027485")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x04027486 RID: 160902
		[Token(Token = "0x4027486")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string, FriendAssistItemFloatPanel.ItemType> onItemClicked;

		// Token: 0x04027487 RID: 160903
		[Token(Token = "0x4027487")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedEquipId;

		// Token: 0x04027488 RID: 160904
		[Token(Token = "0x4027488")]
		[FieldOffset(Offset = "0x80")]
		private UICommonEquipTypeIcon m_equipIcon;

		// Token: 0x04027489 RID: 160905
		[Token(Token = "0x4027489")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0402748A RID: 160906
		[Token(Token = "0x402748A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402748B RID: 160907
		[Token(Token = "0x402748B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402748C RID: 160908
		[Token(Token = "0x402748C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402748D RID: 160909
		[Token(Token = "0x402748D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D99 RID: 19865
		[Token(Token = "0x2004D99")]
		public class RenderOptions
		{
			// Token: 0x0601DB85 RID: 121733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB85")]
			[Address(RVA = "0x174F750", Offset = "0x174E350", VA = "0x18174F750")]
			public RenderOptions()
			{
			}

			// Token: 0x0402748E RID: 160910
			[Token(Token = "0x402748E")]
			[FieldOffset(Offset = "0x10")]
			public bool locked;

			// Token: 0x0402748F RID: 160911
			[Token(Token = "0x402748F")]
			[FieldOffset(Offset = "0x14")]
			public int level;

			// Token: 0x04027490 RID: 160912
			[Token(Token = "0x4027490")]
			[FieldOffset(Offset = "0x18")]
			public bool shining;

			// Token: 0x04027491 RID: 160913
			[Token(Token = "0x4027491")]
			[FieldOffset(Offset = "0x19")]
			public bool selected;

			// Token: 0x04027492 RID: 160914
			[Token(Token = "0x4027492")]
			[FieldOffset(Offset = "0x1A")]
			public bool isNone;

			// Token: 0x04027493 RID: 160915
			[Token(Token = "0x4027493")]
			[FieldOffset(Offset = "0x1B")]
			public bool clickable;

			// Token: 0x04027494 RID: 160916
			[Token(Token = "0x4027494")]
			[FieldOffset(Offset = "0x1C")]
			public float parentScale;
		}
	}
}
