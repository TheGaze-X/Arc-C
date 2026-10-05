using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033C5 RID: 13253
	[Token(Token = "0x20033C5")]
	public class UIBattleSandboxResBackpackBottomBarItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0601525A RID: 86618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003232")]
		private GameModeFactory.SandboxGameMode sandboxGameMode
		{
			[Token(Token = "0x601525A")]
			[Address(RVA = "0xD94AC0", Offset = "0xD936C0", VA = "0x180D94AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601525B RID: 86619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601525B")]
		[Address(RVA = "0xD94640", Offset = "0xD93240", VA = "0x180D94640")]
		public void SetData(string itemId)
		{
		}

		// Token: 0x0601525C RID: 86620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601525C")]
		[Address(RVA = "0xD94960", Offset = "0xD93560", VA = "0x180D94960")]
		private Sprite _LoadItemIcon(string itemId)
		{
			return null;
		}

		// Token: 0x0601525D RID: 86621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601525D")]
		[Address(RVA = "0xD94A60", Offset = "0xD93660", VA = "0x180D94A60")]
		public UIBattleSandboxResBackpackBottomBarItem()
		{
		}

		// Token: 0x04019385 RID: 103301
		[Token(Token = "0x4019385")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x04019386 RID: 103302
		[Token(Token = "0x4019386")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _totalCountText;

		// Token: 0x04019387 RID: 103303
		[Token(Token = "0x4019387")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _colorWater;

		// Token: 0x04019388 RID: 103304
		[Token(Token = "0x4019388")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x04019389 RID: 103305
		[Token(Token = "0x4019389")]
		[FieldOffset(Offset = "0x48")]
		private int m_countTotal;

		// Token: 0x0401938A RID: 103306
		[Token(Token = "0x401938A")]
		[FieldOffset(Offset = "0x50")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x0401938B RID: 103307
		[Token(Token = "0x401938B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sandboxGameMode;

		// Token: 0x0401938C RID: 103308
		[Token(Token = "0x401938C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401938D RID: 103309
		[Token(Token = "0x401938D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadItemIcon;

		// Token: 0x0401938E RID: 103310
		[Token(Token = "0x401938E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
