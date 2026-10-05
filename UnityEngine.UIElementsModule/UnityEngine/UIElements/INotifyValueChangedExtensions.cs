using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	public static class INotifyValueChangedExtensions
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x600081F")]
		public static bool RegisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback)
		{
			return default(bool);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x6000820")]
		public static bool UnregisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback)
		{
			return default(bool);
		}
	}
}
