using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x02003392 RID: 13202
	[Token(Token = "0x2003392")]
	public class UISpeedSwitcher : MonoBehaviour
	{
		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x060150C7 RID: 86215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003202")]
		public Button SpeedSwitcherButton
		{
			[Token(Token = "0x60150C7")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x060150C8 RID: 86216 RVA: 0x0008A2A0 File Offset: 0x000884A0
		[Token(Token = "0x17003203")]
		public virtual bool interactable
		{
			[Token(Token = "0x60150C8")]
			[Address(RVA = "0xD7AF00", Offset = "0xD79B00", VA = "0x180D7AF00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060150C9 RID: 86217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150C9")]
		[Address(RVA = "0xD7AD30", Offset = "0xD79930", VA = "0x180D7AD30")]
		public void SyncToCurrentValue()
		{
		}

		// Token: 0x060150CA RID: 86218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150CA")]
		[Address(RVA = "0xD7ABA0", Offset = "0xD797A0", VA = "0x180D7ABA0")]
		public void SetInteractable(bool val, bool force = false)
		{
		}

		// Token: 0x060150CB RID: 86219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150CB")]
		[Address(RVA = "0xD7AD30", Offset = "0xD79930", VA = "0x180D7AD30")]
		private void _OnSpeedLevelChanged(object arg)
		{
		}

		// Token: 0x060150CC RID: 86220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150CC")]
		[Address(RVA = "0xD7ADA0", Offset = "0xD799A0", VA = "0x180D7ADA0")]
		private void _UpdateSpeedLevel()
		{
		}

		// Token: 0x060150CD RID: 86221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150CD")]
		[Address(RVA = "0xD7AC50", Offset = "0xD79850", VA = "0x180D7AC50")]
		private void Start()
		{
		}

		// Token: 0x060150CE RID: 86222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150CE")]
		[Address(RVA = "0xD7AA80", Offset = "0xD79680", VA = "0x180D7AA80")]
		private void OnDestroy()
		{
		}

		// Token: 0x060150CF RID: 86223 RVA: 0x0008A2B8 File Offset: 0x000884B8
		[Token(Token = "0x60150CF")]
		[Address(RVA = "0xD7AD40", Offset = "0xD79940", VA = "0x180D7AD40")]
		private bool _IsFunctionDisabled()
		{
			return default(bool);
		}

		// Token: 0x060150D0 RID: 86224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150D0")]
		[Address(RVA = "0xD7AEA0", Offset = "0xD79AA0", VA = "0x180D7AEA0")]
		public UISpeedSwitcher()
		{
		}

		// Token: 0x040190E1 RID: 102625
		[Token(Token = "0x40190E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x040190E2 RID: 102626
		[Token(Token = "0x40190E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite[] _sprites;

		// Token: 0x040190E3 RID: 102627
		[Token(Token = "0x40190E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _image;
	}
}
