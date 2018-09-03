-- Load some default values for our rectangle.
function love.load()
    
    Cobra = {
        x = 0, 
        y = 0, 
        l = 10, 
        a = 10,
        atual_x = 200,
        atual_y = 200,
        velocidade = 10
    }
    

    -- Carrega o tamanho do canvas
    Canvas = {
        largura = 540,
        altura = 320
    }
    
    -- Carrega a posição da fruta
    math.randomseed( os.time() )
    Fruta = {
        x = math.random( 0, 53 )*10,
        y = math.random( 0, 31 )*10
    }
    
    love.window.setMode(Canvas.largura, Canvas.altura, {resizable = true})
end

function love.update(dt)
    Cobra.atual_y = Cobra.atual_y - ((Cobra.atual_y - Cobra.y) * (Cobra.velocidade) * dt)
	Cobra.atual_x = Cobra.atual_x - ((Cobra.atual_x - Cobra.x) * (Cobra.velocidade) * dt)
end
 
function love.keypressed(key)
        if key == "up"        then
            function love.update(dt)
                Cobra.y = Cobra.y - 10
            end
        elseif key == "down"  then
            function love.update(dt)
                Cobra.y = Cobra.y + 10
            end
        elseif key == "right" then
            function love.update(dt)
                Cobra.x = Cobra.x + 10
            end
        elseif key == "left"  then
            function love.update(dt)
                Cobra.x = Cobra.x - 10
            end
    end
end

function snake()
    love.graphics.setColor(255, 255, 255)    
    love.graphics.rectangle("fill", Cobra.x, Cobra.y, Cobra.l, Cobra.a)
end

function comida()
    love.graphics.setColor(255, 255, 255)    
    love.graphics.rectangle("fill", Fruta.x, Fruta.y, 10, 10)
end
 
function love.draw()
    
    snake()
    comida()
    --key()
    love.graphics.setColor(255, 255, 255)
    love.graphics.print("X"..Cobra.x.." Y"..Cobra.y, 20, 20)
    love.graphics.print("X"..Fruta.x.." Y"..Fruta.y, 20, 40)

end
-- Draw a coloured rectangle.
