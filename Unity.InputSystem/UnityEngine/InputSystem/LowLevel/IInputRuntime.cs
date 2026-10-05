using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	internal interface IInputRuntime
	{
		// Token: 0x060010A3 RID: 4259
		[Token(Token = "0x60010A3")]
		int AllocateDeviceId();

		// Token: 0x060010A4 RID: 4260
		[Token(Token = "0x60010A4")]
		void Update(InputUpdateType type);

		// Token: 0x060010A5 RID: 4261
		[Token(Token = "0x60010A5")]
		unsafe void QueueEvent(InputEvent* ptr);

		// Token: 0x060010A6 RID: 4262
		[Token(Token = "0x60010A6")]
		unsafe long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr);

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060010A7 RID: 4263
		// (set) Token: 0x060010A8 RID: 4264
		[Token(Token = "0x170004B6")]
		InputUpdateDelegate onUpdate { [Token(Token = "0x60010A7")] get; [Token(Token = "0x60010A8")] set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060010A9 RID: 4265
		// (set) Token: 0x060010AA RID: 4266
		[Token(Token = "0x170004B7")]
		Action<InputUpdateType> onBeforeUpdate { [Token(Token = "0x60010A9")] get; [Token(Token = "0x60010AA")] set; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060010AB RID: 4267
		// (set) Token: 0x060010AC RID: 4268
		[Token(Token = "0x170004B8")]
		Func<InputUpdateType, bool> onShouldRunUpdate { [Token(Token = "0x60010AB")] get; [Token(Token = "0x60010AC")] set; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060010AD RID: 4269
		// (set) Token: 0x060010AE RID: 4270
		[Token(Token = "0x170004B9")]
		Action<int, string> onDeviceDiscovered { [Token(Token = "0x60010AD")] get; [Token(Token = "0x60010AE")] set; }

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060010AF RID: 4271
		// (set) Token: 0x060010B0 RID: 4272
		[Token(Token = "0x170004BA")]
		Action<bool> onPlayerFocusChanged { [Token(Token = "0x60010AF")] get; [Token(Token = "0x60010B0")] set; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060010B1 RID: 4273
		[Token(Token = "0x170004BB")]
		bool isPlayerFocused { [Token(Token = "0x60010B1")] get; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060010B2 RID: 4274
		// (set) Token: 0x060010B3 RID: 4275
		[Token(Token = "0x170004BC")]
		Action onShutdown { [Token(Token = "0x60010B2")] get; [Token(Token = "0x60010B3")] set; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060010B4 RID: 4276
		// (set) Token: 0x060010B5 RID: 4277
		[Token(Token = "0x170004BD")]
		float pollingFrequency { [Token(Token = "0x60010B4")] get; [Token(Token = "0x60010B5")] set; }

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060010B6 RID: 4278
		[Token(Token = "0x170004BE")]
		double currentTime { [Token(Token = "0x60010B6")] get; }

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060010B7 RID: 4279
		[Token(Token = "0x170004BF")]
		double currentTimeForFixedUpdate { [Token(Token = "0x60010B7")] get; }

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060010B8 RID: 4280
		[Token(Token = "0x170004C0")]
		float unscaledGameTime { [Token(Token = "0x60010B8")] get; }

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060010B9 RID: 4281
		[Token(Token = "0x170004C1")]
		double currentTimeOffsetToRealtimeSinceStartup { [Token(Token = "0x60010B9")] get; }

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060010BA RID: 4282
		// (set) Token: 0x060010BB RID: 4283
		[Token(Token = "0x170004C2")]
		bool runInBackground { [Token(Token = "0x60010BA")] get; [Token(Token = "0x60010BB")] set; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060010BC RID: 4284
		[Token(Token = "0x170004C3")]
		Vector2 screenSize { [Token(Token = "0x60010BC")] get; }

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060010BD RID: 4285
		[Token(Token = "0x170004C4")]
		ScreenOrientation screenOrientation { [Token(Token = "0x60010BD")] get; }

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060010BE RID: 4286
		[Token(Token = "0x170004C5")]
		bool isInBatchMode { [Token(Token = "0x60010BE")] get; }
	}
}
