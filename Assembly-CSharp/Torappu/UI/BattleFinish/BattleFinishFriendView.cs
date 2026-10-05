using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006205 RID: 25093
	[Token(Token = "0x2006205")]
	public class BattleFinishFriendView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024351 RID: 148305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024351")]
		[Address(RVA = "0x1F14530", Offset = "0x1F13130", VA = "0x181F14530")]
		public void ApplyData(SquadFriendData data)
		{
		}

		// Token: 0x06024352 RID: 148306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024352")]
		[Address(RVA = "0x1F14950", Offset = "0x1F13550", VA = "0x181F14950")]
		private string _TimeText(DateTime lastOnlineTime)
		{
			return null;
		}

		// Token: 0x06024353 RID: 148307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024353")]
		[Address(RVA = "0x1F14B80", Offset = "0x1F13780", VA = "0x181F14B80")]
		public BattleFinishFriendView()
		{
		}

		// Token: 0x04032574 RID: 206196
		[Token(Token = "0x4032574")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _friendName;

		// Token: 0x04032575 RID: 206197
		[Token(Token = "0x4032575")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _awayTime;

		// Token: 0x04032576 RID: 206198
		[Token(Token = "0x4032576")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _friendLvl;

		// Token: 0x04032577 RID: 206199
		[Token(Token = "0x4032577")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _serverName;

		// Token: 0x04032578 RID: 206200
		[Token(Token = "0x4032578")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _friendid;

		// Token: 0x04032579 RID: 206201
		[Token(Token = "0x4032579")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _onlineState;

		// Token: 0x0403257A RID: 206202
		[Token(Token = "0x403257A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _addFriendText;

		// Token: 0x0403257B RID: 206203
		[Token(Token = "0x403257B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x0403257C RID: 206204
		[Token(Token = "0x403257C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x0403257D RID: 206205
		[Token(Token = "0x403257D")]
		[FieldOffset(Offset = "0x5C")]
		[NonSerialized]
		public int index;

		// Token: 0x0403257E RID: 206206
		[Token(Token = "0x403257E")]
		[FieldOffset(Offset = "0x60")]
		protected FriendData friendData;

		// Token: 0x0403257F RID: 206207
		[Token(Token = "0x403257F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04032580 RID: 206208
		[Token(Token = "0x4032580")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TimeText;

		// Token: 0x04032581 RID: 206209
		[Token(Token = "0x4032581")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
