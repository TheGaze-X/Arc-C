using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02004004 RID: 16388
	[Token(Token = "0x2004004")]
	public class SettingVoiceLangItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019600 RID: 103936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019600")]
		[Address(RVA = "0x1227CB0", Offset = "0x12268B0", VA = "0x181227CB0")]
		public void Setup(VoiceLangType voiceLang, Action<VoiceLangType> onClicked)
		{
		}

		// Token: 0x06019601 RID: 103937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019601")]
		[Address(RVA = "0x1227C40", Offset = "0x1226840", VA = "0x181227C40")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06019602 RID: 103938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019602")]
		[Address(RVA = "0x1227DB0", Offset = "0x12269B0", VA = "0x181227DB0")]
		public SettingVoiceLangItem()
		{
		}

		// Token: 0x0401F92B RID: 129323
		[Token(Token = "0x401F92B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textBtn;

		// Token: 0x0401F92C RID: 129324
		[Token(Token = "0x401F92C")]
		[FieldOffset(Offset = "0x20")]
		private Action<VoiceLangType> m_onClicked;

		// Token: 0x0401F92D RID: 129325
		[Token(Token = "0x401F92D")]
		[FieldOffset(Offset = "0x28")]
		private VoiceLangType m_voiceLang;

		// Token: 0x0401F92E RID: 129326
		[Token(Token = "0x401F92E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0401F92F RID: 129327
		[Token(Token = "0x401F92F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0401F930 RID: 129328
		[Token(Token = "0x401F930")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
