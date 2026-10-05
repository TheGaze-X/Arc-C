using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051E5 RID: 20965
	[Token(Token = "0x20051E5")]
	public class RoguelikeCustomNotifyController : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601EF64 RID: 126820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF64")]
		[Address(RVA = "0x18B0CD0", Offset = "0x18AF8D0", VA = "0x1818B0CD0")]
		public void DoNotify(string path, ValueBundle options, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601EF65 RID: 126821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF65")]
		[Address(RVA = "0x18B1140", Offset = "0x18AFD40", VA = "0x1818B1140")]
		private void _TriggerNotifyComplete(RoguelikeCustomNotifyType notifyType)
		{
		}

		// Token: 0x0601EF66 RID: 126822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF66")]
		[Address(RVA = "0x18B1290", Offset = "0x18AFE90", VA = "0x1818B1290")]
		public RoguelikeCustomNotifyController()
		{
		}

		// Token: 0x040298D6 RID: 170198
		[Token(Token = "0x40298D6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _notifyContainer;

		// Token: 0x040298D7 RID: 170199
		[Token(Token = "0x40298D7")]
		[FieldOffset(Offset = "0x20")]
		private EnumIntDictionary<RoguelikeCustomNotifyType, RoguelikeCustomNotify> m_customNotifyDict;

		// Token: 0x040298D8 RID: 170200
		[Token(Token = "0x40298D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoNotify;

		// Token: 0x040298D9 RID: 170201
		[Token(Token = "0x40298D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TriggerNotifyComplete;

		// Token: 0x040298DA RID: 170202
		[Token(Token = "0x40298DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
