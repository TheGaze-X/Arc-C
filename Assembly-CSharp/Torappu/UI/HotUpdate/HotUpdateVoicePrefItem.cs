using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.CharWord;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A9D RID: 19101
	[Token(Token = "0x2004A9D")]
	public class HotUpdateVoicePrefItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x170043B0 RID: 17328
		// (get) Token: 0x0601CB2B RID: 117547 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CB2C RID: 117548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043B0")]
		public Action<VoiceLangManager.HotUpdatePref> onClicked
		{
			[Token(Token = "0x601CB2B")]
			[Address(RVA = "0x1628AE0", Offset = "0x16276E0", VA = "0x181628AE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601CB2C")]
			[Address(RVA = "0x1628B40", Offset = "0x1627740", VA = "0x181628B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601CB2D RID: 117549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB2D")]
		[Address(RVA = "0x1628410", Offset = "0x1627010", VA = "0x181628410")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0601CB2E RID: 117550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB2E")]
		[Address(RVA = "0x16284E0", Offset = "0x16270E0", VA = "0x1816284E0")]
		public void Render(HotUpdateVoicePrefItem.Options options)
		{
		}

		// Token: 0x0601CB2F RID: 117551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB2F")]
		[Address(RVA = "0x1628900", Offset = "0x1627500", VA = "0x181628900")]
		private void _UpdateContent(VoiceLangManager.HotUpdatePref newViewPref)
		{
		}

		// Token: 0x0601CB30 RID: 117552 RVA: 0x000A9200 File Offset: 0x000A7400
		[Token(Token = "0x601CB30")]
		[Address(RVA = "0x16286D0", Offset = "0x16272D0", VA = "0x1816286D0")]
		private static HotUpdateVoicePrefItem.ViewData _GetViewDataFromPref(VoiceLangManager.HotUpdatePref pref)
		{
			return default(HotUpdateVoicePrefItem.ViewData);
		}

		// Token: 0x0601CB31 RID: 117553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB31")]
		[Address(RVA = "0x1628A80", Offset = "0x1627680", VA = "0x181628A80")]
		public HotUpdateVoicePrefItem()
		{
		}

		// Token: 0x04025AD8 RID: 154328
		[Token(Token = "0x4025AD8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04025AD9 RID: 154329
		[Token(Token = "0x4025AD9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text[] _textDescs;

		// Token: 0x04025ADA RID: 154330
		[Token(Token = "0x4025ADA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04025ADB RID: 154331
		[Token(Token = "0x4025ADB")]
		[FieldOffset(Offset = "0x30")]
		private VoiceLangManager.HotUpdatePref m_cachedPref;

		// Token: 0x04025ADD RID: 154333
		[Token(Token = "0x4025ADD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x04025ADE RID: 154334
		[Token(Token = "0x4025ADE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x04025ADF RID: 154335
		[Token(Token = "0x4025ADF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04025AE0 RID: 154336
		[Token(Token = "0x4025AE0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025AE1 RID: 154337
		[Token(Token = "0x4025AE1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x04025AE2 RID: 154338
		[Token(Token = "0x4025AE2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetViewDataFromPref;

		// Token: 0x04025AE3 RID: 154339
		[Token(Token = "0x4025AE3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A9E RID: 19102
		[Token(Token = "0x2004A9E")]
		public struct Options
		{
			// Token: 0x04025AE4 RID: 154340
			[Token(Token = "0x4025AE4")]
			[FieldOffset(Offset = "0x0")]
			public VoiceLangManager.HotUpdatePref selected;

			// Token: 0x04025AE5 RID: 154341
			[Token(Token = "0x4025AE5")]
			[FieldOffset(Offset = "0x4")]
			public VoiceLangManager.HotUpdatePref viewPref;
		}

		// Token: 0x02004A9F RID: 19103
		[Token(Token = "0x2004A9F")]
		private struct ViewData
		{
			// Token: 0x04025AE6 RID: 154342
			[Token(Token = "0x4025AE6")]
			[FieldOffset(Offset = "0x0")]
			public string title;

			// Token: 0x04025AE7 RID: 154343
			[Token(Token = "0x4025AE7")]
			[FieldOffset(Offset = "0x8")]
			public string desc;
		}
	}
}
