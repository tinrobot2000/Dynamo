## 详细
“Curve Mapper”节点重新分布定义范围内的一系列输入值，并利用数学曲线沿指定的曲线映射它们。此上下文中的映射表示值以其 x 坐标沿 y 轴跟随曲线形状的方式重新分布。该技术对于立面设计、参数化屋顶结构和其他需要特定图案或分布的设计计算等应用特别有价值。

通过设置最小值和最大值来定义 x 坐标的限制。这些限制设置了将在其中重新分布点的边界。可以提供单个计数以生成一系列均匀分布的值，或一系列现有值，它们将在指定的范围内沿 X 方向分布，然后映射到曲线。

从提供的选项中选择数学曲线，包括“线性”、“正弦”、“余弦”、“柏林噪波”、“贝塞尔曲线”、“高斯曲线”、“抛物线”、“平方根”和“幂曲线”。使用交互式控制点调整所选曲线的形状，从而根据您的特定需求进行定制。

可以使用锁定按钮锁定曲线形状，这样可以防止对曲线进行进一步修改。此外，还可以使用节点内的重置按钮将形状重置为其默认状态。如果获取 NaN 或 Null 作为输出，可以在 [此处](https://dynamobim.org/introducing-the-curve-mapper-node-in-dynamo/#CurveMapper_Known_Issues)找到有关为何可能会看到此内容的更多详细信息。

例如，要沿范围为 0 到 20 的正弦曲线重新分布 80 个点，请将“最小值”设置为 0，将“最大值”设置为 20，将“值数”设置为 80。选择正弦曲线并根据需要调整其形状后，“Curve Mapper”节点会输出 80 个带有 x 坐标的点，这些 x 坐标沿 y 轴跟随正弦曲线图案。

要沿高斯曲线映射分布不均匀的值，请设置最小和最大范围，并提供一系列值。选择高斯曲线并根据需要调整其形状之后，“曲线映射器”节点将使用指定的范围沿 x 坐标重新分配一系列值，并沿曲线图案映射这些值。有关该节点的工作方式以及如何设置输入的详细文档，请查看 [此博客帖子](https://dynamobim.org/introducing-the-curve-mapper-node-in-dynamo)，重点关注“曲线映射器”。




___
## 示例文件

![Example](./GV5KUSHDGL7YVBZAR4HEGY5NIXFIG3XTV6ZQPHC5MWWGEVOSRJ4Q_img.png)
