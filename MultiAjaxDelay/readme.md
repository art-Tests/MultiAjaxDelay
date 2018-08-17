# 實際測試

開啟網站 http://localhost:6090/MultiAjaxDelay/index.html

本次測試主要針對後端接收請求所發生的阻塞現象，情境為僅有少數的連線請求；大量連線請求受限於瀏覽器本身。

## 正常情況 (未使用到 Session)

實際測試各種情境，大致上所發出的 ajax 請求會受到瀏覽器的限制，IE 可以透過修改機碼變更瀏覽器的同時請求連線數量。

## 異常情況 (使用到 Session)

當後端程式有使用到 `session`，導致前端後續發出的 `ajax` 請求也會帶上 `request cookie`。
<img src="./2018-08-17_12-21-59.png"/>
<img src="./2018-08-17_12-27-14.png"/>

後端模擬接收到請求之後 delay 3 秒鐘，前端每隔 1 秒送一次請求。

在比對本次測試的情境，一個 ajax 正常執行；另外一個後端處理先睡 5 秒在回應，看看兩個 ajax 是否會一起將結果拋回前端。測試結果如下
<img src="./2018-08-17_12-34-51.png"/>

可以看到在 Home Controller 的部分，已經有 session 的情況下，送出請求將會出現同時回應的情況。

而 Test Controller 與 ReadOnly Controller 的情況下，分別設置了

```
[SessionState(SessionStateBehavior.Disabled)]
```

```
[SessionState(SessionStateBehavior.ReadOnly)]
```

執行結果就正常
