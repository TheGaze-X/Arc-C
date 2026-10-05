using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.UI
{
	// Token: 0x020032FE RID: 13054
	[Token(Token = "0x20032FE")]
	public class UIBattleStartPanel : MonoBehaviour
	{
		// Token: 0x06014BC6 RID: 84934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BC6")]
		[Address(RVA = "0xD21E70", Offset = "0xD20A70", VA = "0x180D21E70")]
		public void Show(Action finishCb)
		{
		}

		// Token: 0x06014BC7 RID: 84935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BC7")]
		[Address(RVA = "0xD220A0", Offset = "0xD20CA0", VA = "0x180D220A0")]
		private void _OnComplete(bool completed)
		{
		}

		// Token: 0x06014BC8 RID: 84936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BC8")]
		[Address(RVA = "0xD21F30", Offset = "0xD20B30", VA = "0x180D21F30")]
		private void Start()
		{
		}

		// Token: 0x06014BC9 RID: 84937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BC9")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIBattleStartPanel()
		{
		}

		// Token: 0x04018A62 RID: 100962
		[Token(Token = "0x4018A62")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIStageInfo _stageInfo;

		// Token: 0x04018A63 RID: 100963
		[Token(Token = "0x4018A63")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationPerform _perform;

		// Token: 0x04018A64 RID: 100964
		[Token(Token = "0x4018A64")]
		[FieldOffset(Offset = "0x28")]
		private Action m_finishCb;
	}
}
