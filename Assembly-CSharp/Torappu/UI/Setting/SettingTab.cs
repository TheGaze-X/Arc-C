using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02004001 RID: 16385
	[Token(Token = "0x2004001")]
	[RequireComponent(typeof(Animator))]
	public class SettingTab : MonoBehaviour, IHotfixable
	{
		// Token: 0x060195F3 RID: 103923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195F3")]
		[Address(RVA = "0x1226EA0", Offset = "0x1225AA0", VA = "0x181226EA0")]
		public void SetString(string textId, float offset, int pos, bool needShowDecro)
		{
		}

		// Token: 0x060195F4 RID: 103924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195F4")]
		[Address(RVA = "0x1226DF0", Offset = "0x12259F0", VA = "0x181226DF0")]
		public void SetCommonObjectEnabled(bool enabled)
		{
		}

		// Token: 0x060195F5 RID: 103925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195F5")]
		[Address(RVA = "0x12270D0", Offset = "0x1225CD0", VA = "0x1812270D0")]
		private void _OnClick()
		{
		}

		// Token: 0x060195F6 RID: 103926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195F6")]
		[Address(RVA = "0x1226D50", Offset = "0x1225950", VA = "0x181226D50")]
		public void ChangeType(bool state)
		{
		}

		// Token: 0x060195F7 RID: 103927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195F7")]
		[Address(RVA = "0x1227140", Offset = "0x1225D40", VA = "0x181227140")]
		public SettingTab()
		{
		}

		// Token: 0x0401F913 RID: 129299
		[Token(Token = "0x401F913")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x0401F914 RID: 129300
		[Token(Token = "0x401F914")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0401F915 RID: 129301
		[Token(Token = "0x401F915")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _text;

		// Token: 0x0401F916 RID: 129302
		[Token(Token = "0x401F916")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _showIfNotFirst;

		// Token: 0x0401F917 RID: 129303
		[Token(Token = "0x401F917")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public Action<int> OnChangeTab;

		// Token: 0x0401F918 RID: 129304
		[Token(Token = "0x401F918")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public int index;

		// Token: 0x0401F919 RID: 129305
		[Token(Token = "0x401F919")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetString;

		// Token: 0x0401F91A RID: 129306
		[Token(Token = "0x401F91A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetCommonObjectEnabled;

		// Token: 0x0401F91B RID: 129307
		[Token(Token = "0x401F91B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnClick;

		// Token: 0x0401F91C RID: 129308
		[Token(Token = "0x401F91C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeType;

		// Token: 0x0401F91D RID: 129309
		[Token(Token = "0x401F91D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
