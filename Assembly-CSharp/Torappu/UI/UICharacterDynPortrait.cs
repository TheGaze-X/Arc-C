using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003533 RID: 13619
	[Token(Token = "0x2003533")]
	public class UICharacterDynPortrait : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x06015B53 RID: 88915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003392")]
		public SkeletonGraphic graphic
		{
			[Token(Token = "0x6015B53")]
			[Address(RVA = "0xE4D430", Offset = "0xE4C030", VA = "0x180E4D430")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015B54 RID: 88916 RVA: 0x0008D948 File Offset: 0x0008BB48
		[Token(Token = "0x6015B54")]
		[Address(RVA = "0xE4D320", Offset = "0xE4BF20", VA = "0x180E4D320")]
		private bool _SetAnimation(string animKey, bool loop)
		{
			return default(bool);
		}

		// Token: 0x06015B55 RID: 88917 RVA: 0x0008D960 File Offset: 0x0008BB60
		[Token(Token = "0x6015B55")]
		[Address(RVA = "0xE4D0D0", Offset = "0xE4BCD0", VA = "0x180E4D0D0")]
		private bool _AddAnimation(string animKey, bool loop)
		{
			return default(bool);
		}

		// Token: 0x06015B56 RID: 88918 RVA: 0x0008D978 File Offset: 0x0008BB78
		[Token(Token = "0x6015B56")]
		[Address(RVA = "0xE4D180", Offset = "0xE4BD80", VA = "0x180E4D180")]
		private bool _PlayAnimation(string animKey, bool loop, bool isAdd, out float time)
		{
			return default(bool);
		}

		// Token: 0x06015B57 RID: 88919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B57")]
		[Address(RVA = "0xE4D020", Offset = "0xE4BC20", VA = "0x180E4D020")]
		private void Start()
		{
		}

		// Token: 0x06015B58 RID: 88920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B58")]
		[Address(RVA = "0xE4D3D0", Offset = "0xE4BFD0", VA = "0x180E4D3D0")]
		public UICharacterDynPortrait()
		{
		}

		// Token: 0x0401A13B RID: 106811
		[Token(Token = "0x401A13B")]
		[NonSerialized]
		public const string IDLE_ANIM = "Idle";

		// Token: 0x0401A13C RID: 106812
		[Token(Token = "0x401A13C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkeletonGraphic _graphic;

		// Token: 0x0401A13D RID: 106813
		[Token(Token = "0x401A13D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0401A13E RID: 106814
		[Token(Token = "0x401A13E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetAnimation;

		// Token: 0x0401A13F RID: 106815
		[Token(Token = "0x401A13F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AddAnimation;

		// Token: 0x0401A140 RID: 106816
		[Token(Token = "0x401A140")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayAnimation;

		// Token: 0x0401A141 RID: 106817
		[Token(Token = "0x401A141")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401A142 RID: 106818
		[Token(Token = "0x401A142")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
