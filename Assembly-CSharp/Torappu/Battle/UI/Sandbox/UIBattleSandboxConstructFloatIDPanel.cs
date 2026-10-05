using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033AC RID: 13228
	[Token(Token = "0x20033AC")]
	public class UIBattleSandboxConstructFloatIDPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060151CF RID: 86479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151CF")]
		[Address(RVA = "0xD88A70", Offset = "0xD87670", VA = "0x180D88A70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060151D0 RID: 86480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60151D0")]
		[Address(RVA = "0xD888F0", Offset = "0xD874F0", VA = "0x180D888F0")]
		private string _GetId()
		{
			return null;
		}

		// Token: 0x060151D1 RID: 86481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151D1")]
		[Address(RVA = "0xD89170", Offset = "0xD87D70", VA = "0x180D89170")]
		private void _InitSetting()
		{
		}

		// Token: 0x060151D2 RID: 86482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151D2")]
		[Address(RVA = "0xD88840", Offset = "0xD87440", VA = "0x180D88840")]
		public void Show()
		{
		}

		// Token: 0x060151D3 RID: 86483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151D3")]
		[Address(RVA = "0xD88790", Offset = "0xD87390", VA = "0x180D88790")]
		public void Hide()
		{
		}

		// Token: 0x060151D4 RID: 86484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151D4")]
		[Address(RVA = "0xD89280", Offset = "0xD87E80", VA = "0x180D89280")]
		public UIBattleSandboxConstructFloatIDPanel()
		{
		}

		// Token: 0x0401926E RID: 103022
		[Token(Token = "0x401926E")]
		private const string ID_TEXT_FORMAT = "{0}{2}#{1}";

		// Token: 0x0401926F RID: 103023
		[Token(Token = "0x401926F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Canvas _rootCanvas;

		// Token: 0x04019270 RID: 103024
		[Token(Token = "0x4019270")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x04019271 RID: 103025
		[Token(Token = "0x4019271")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _prefabEmpty;

		// Token: 0x04019272 RID: 103026
		[Token(Token = "0x4019272")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _root;

		// Token: 0x04019273 RID: 103027
		[Token(Token = "0x4019273")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GridLayoutGroup _gridLayout;

		// Token: 0x04019274 RID: 103028
		[Token(Token = "0x4019274")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04019275 RID: 103029
		[Token(Token = "0x4019275")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _targetAlpha;

		// Token: 0x04019276 RID: 103030
		[Token(Token = "0x4019276")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _fadeTime;

		// Token: 0x04019277 RID: 103031
		[Token(Token = "0x4019277")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _mask;

		// Token: 0x04019278 RID: 103032
		[Token(Token = "0x4019278")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _hintText;

		// Token: 0x04019279 RID: 103033
		[Token(Token = "0x4019279")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _idText;

		// Token: 0x0401927A RID: 103034
		[Token(Token = "0x401927A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIBattleSandboxConstructFloatIDPanel.IdTextSetting _inLandSetting;

		// Token: 0x0401927B RID: 103035
		[Token(Token = "0x401927B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIBattleSandboxConstructFloatIDPanel.IdTextSetting _i18nSetting;

		// Token: 0x0401927C RID: 103036
		[Token(Token = "0x401927C")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x0401927D RID: 103037
		[Token(Token = "0x401927D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401927E RID: 103038
		[Token(Token = "0x401927E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetId;

		// Token: 0x0401927F RID: 103039
		[Token(Token = "0x401927F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitSetting;

		// Token: 0x04019280 RID: 103040
		[Token(Token = "0x4019280")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04019281 RID: 103041
		[Token(Token = "0x4019281")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04019282 RID: 103042
		[Token(Token = "0x4019282")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033AD RID: 13229
		[Token(Token = "0x20033AD")]
		[Serializable]
		private class IdTextSetting
		{
			// Token: 0x060151D5 RID: 86485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60151D5")]
			[Address(RVA = "0xD824C0", Offset = "0xD810C0", VA = "0x180D824C0")]
			public void Apply(Text hintText, Text idText)
			{
			}

			// Token: 0x060151D6 RID: 86486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60151D6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public IdTextSetting()
			{
			}

			// Token: 0x04019283 RID: 103043
			[Token(Token = "0x4019283")]
			[FieldOffset(Offset = "0x10")]
			public string hintVal;

			// Token: 0x04019284 RID: 103044
			[Token(Token = "0x4019284")]
			[FieldOffset(Offset = "0x18")]
			public float idWidth;
		}
	}
}
